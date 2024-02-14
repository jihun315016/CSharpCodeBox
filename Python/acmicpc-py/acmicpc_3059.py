# 3059 등장하지 않는 문자의 합

t = int(input())
dic = {}

for _ in range(t):
    sInput = input()
    k = 0

    for i in range(ord('A'), ord('Z') + 1):
        dic[chr(i)] = False

    for s in sInput:
        dic[s] = True
    
    for d in dic:
        if not dic[d]:
            k = k + ord(d)
    
    print(k)
