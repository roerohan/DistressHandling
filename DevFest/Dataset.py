# -*- coding: utf-8 -*-
"""
Text store
"""
#text_container = page_soup.body.find('div',{'id':'container'}).find('div',{'class':'content clearfix'}).find('div',{'class':'left-content'}).find('div',{'class':'container-inner'}).find('div',{'id':'content'}).find('div',{'class':'MovieReviewCritic reviewTabsID'}).arttextxml.find('div',{'class':'section1'}).find('div',{'class':'Normal'})
from bs4 import BeautifulSoup as soup
from urllib2 import Request
from urllib2 import urlopen as uReq
from nltk.stem.porter import PorterStemmer
from nltk import word_tokenize
from sklearn.feature_extraction.text import CountVectorizer
import string

stemmer = PorterStemmer()
def stem_tokens(tokens, stemmer):
    stemmed = []
    for item in tokens:
        stemmed.append(stemmer.stem(item))
    return stemmed

def tokenize(text):
    tokens = word_tokenize(text)
    tokens = [i for i in tokens if i not in string.punctuation]
    stems = stem_tokens(tokens, stemmer)
    return stems

def wordbinconv(word):
    binr = ''
    for letter in word:
        binr+=str(ord(letter))
    return int(binr), {int(binr):word}

vect = CountVectorizer(tokenizer=tokenize, stop_words='english') 
d ={}

""" Convert crimes and areas into binary representation and check presence of both in text of given link using XOR"""
 






f = open('C:/Users/verma/OneDrive/Desktop/DevFest/CleanedLinks1.txt','r')
links = f.read().split('\n')
f.close()

f = open('C:/Users/verma/OneDrive/Desktop/DevFest/CrimesList.txt','r')
crimes = f.read().lower().split('\n')
cr_dict = {}
for idx in range(0,len(crimes)):        #crimes idx is a crime in crimes
    crimes[idx] = stemmer.stem(crimes[idx])
    crimes[idx], d = wordbinconv(crimes[idx])
    cr_dict.update(d)
f.close()

f = open('C:/Users/verma/OneDrive/Desktop/DevFest/neighbourhoods.txt','r')
locales = f.read().lower().split('\n')
nbr_dict = {}
for idx in range(0,len(locales)):   #locales[idx] is a locale in locales
    locales[idx] = stemmer.stem(locales[idx])
    locales[idx], d = wordbinconv(locales[idx])
    nbr_dict.update(d)
f.close()

crimes_dict = {i:0 for i in crimes}
features = {i:crimes_dict for i in locales}


for link in links:
    if link == '' or link == ' ':
        continue
    headers = {'User-Agent': 'Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.3'}
    req = Request(url=link, headers = headers)
    uClient = uReq(req)
    page_html = uClient.read()
    uClient.close()
    page_soup = soup(page_html, 'html.parser')
    text_container = page_soup.body.find('div',{'id':'container'}).find('div',{'class':'content clearfix'}).find('div',{'class':'left-content'}).find('div',{'class':'container-inner'}).find('div',{'id':'content'}).find('div',{'class':'MovieReviewCritic reviewTabsID'}).arttextxml.find('div',{'class':'section1'}).find('div',{'class':'Normal'})
    for script in text_container.findAll('script'):
        script.decompose()
    text = text_container.text.lower().split()
    print text
    text = vect.fit(text).get_feature_names()
    print text
    for idx in range(0,len(text)):              #text[idx] is a word in text
        text[idx],d = wordbinconv(text[idx])
    for area in features:
        for crime in features[area]:
            flag = False
            for word in text:
                if word^area == 0:
                    flag = True 
                    break
            if flag == True:
                for word in text:
                    if crime^word == 0:
                        features[area][crime]+=1
                        break
    break
"""

f = open('C:/Users/verma/OneDrive/Desktop/DevFest/AllData.txt','w')
f.write(str(cr_dict)+'\n' + str(nbr_dict) + '\n')
f.write(str(features))
f.close()
"""