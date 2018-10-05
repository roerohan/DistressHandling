# -*- coding: utf-8 -*-
"""
Created on Thu Oct  4 22:13:40 2018

@author: verma
"""

def cl_redunc(File):
    l = ''
    File = File.rstrip().split('\n')
    c = 0
    for line in File:
        if line == '' or line == ' ':
            File.remove(line)
            continue
        c=0
        repeat = False
        for l in File:
            if line == l:
                c+=1
            if c == 2:
                repeat = True
                break
        if repeat == True:
            File.remove(line)
    for line in File:
        l+= str(line) + '\n'
    return l
        
if __name__ == '__main__':
    f = open('C:\Users\\verma\OneDrive\Desktop\DevFest\links.txt','r')
    File = f.read()
    f1 = open('C:\Users\\verma\OneDrive\Desktop\DevFest\CleanedLinks1.txt','w')
    f1.write(cl_redunc(File))
    print len(File.split('\n')), len(cl_redunc(File).split('\n'))
    f1.close()
    f.close()