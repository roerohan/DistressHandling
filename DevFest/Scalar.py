# -*- coding: utf-8 -*-
"""
Scaler
"""
from nltk.stem.porter import PorterStemmer
from ast import literal_eval as vall

weights = [2,4,6,7,9,7,8]
stemmer = PorterStemmer()

f = open('C:/Users/verma/OneDrive/Desktop/DevFest/CrimesList.txt','r')
crimes = f.read().split('\n')
for idx in range(0,len(crimes)):
    crimes[idx] = stemmer.stem(crimes[idx])
w_crimes = {} #weighted crimes
for idx in range(0,len(crimes)):
    w_crimes.update({crimes[idx]:weights[idx]})
f.close()

f = open('C:/Users/verma/OneDrive/Desktop/DevFest/neighbourhoods.txt','r')
locales = f.read().lower().split('\n')
st_locales = []     #stemmed locales
for idx in range(0,len(locales)):
    st_locales.append(stemmer.stem(locales[idx]))
f.close()

f = open('C:/Users/verma/OneDrive/Desktop/DevFest/AllData.txt','r')
AllData = f.read().split('\n')
crime_key = vall(AllData[0])
area_key = vall(AllData[1])
Data = vall(AllData[2])
f.close()

total = 0
tot_vals = {}
score_vals = {}   
#Score is probability that a crime occurs in an area given a crime has occured adjusted according to weights of crimes
for area in Data:
    area_total = 0
    for crime in Data[area]:
        area_total += w_crimes[crime_key[crime]]
    tot_vals.update({area_key[area]:area_total})
    total += area_total
    
for area in tot_vals:
    score_vals.update({area:10*float((area_total))/total})
    
f = open('C:/Users/verma/OneDrive/Desktop/DevFest/Scores.csv','w')
area = ''
scores = ''
for locale in locales:
    area += locale + ', '
f.write(area + '\n')
for locale in st_locales:
    scores += str(score_vals[locale]) + ', '
f.write(scores)
f.close()
    
