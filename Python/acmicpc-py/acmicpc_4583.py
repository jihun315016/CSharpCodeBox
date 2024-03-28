# 4583 거울상 

import sys
input = sys.stdin.readline

dic = {
    'b': 'd', 'p': 'q',
    'd': 'b', 'q': 'p',
    'i': 'i', 'o': 'o',
    'v': 'v', 'w': 'w',
    'x': 'x'
}

while True:
    sInput = input().rstrip()[::-1]
    if sInput == '#':
        break
    
    result = ""
    for s in sInput:
        if s not in dic:
            result = "INVALID"
            break
        else:
            result = result + dic[s]
    
    print(result)
