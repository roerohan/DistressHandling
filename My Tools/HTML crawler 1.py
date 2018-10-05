# -*- coding: utf-8 -*-
"""
To extract relevant urls
"""
from bs4 import BeautifulSoup as soup
from urllib2 import Request
from urllib2 import urlopen as uReq

headers = {'User-Agent': 'Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.3'}
#Change URL here
req = Request(url='https://en.wikipedia.org/wiki/List_of_neighbourhoods_in_Bangalore', headers = headers)
##
uClient = uReq(req)
page_html = uClient.read()
uClient.close()
page_soup = soup(page_html, 'html.parser')
table_containers = page_soup.find('body').find('div',{'class':'mw-parser-output'}).findAll('table')
d = {}
for tcont in table_containers:
    d.update({tcont:tcont.findAll('tr')})
locale = ''
container = ''
for table in d:
    for container in d[table]:
        if container.td == None:
            continue
        locale+= container.td.text


#Write data file containing relevant links
f1 = open('C:/Users/verma/OneDrive/Desktop/DevFest/neighbourhoods.txt', 'a')
f1.write(locale)
f1.close()

















