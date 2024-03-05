# 8958 OX퀴즈 

t = int(input())

for _ in range(t):
    sInput = input()
    total = 0
    cur = 1
    for s in sInput:
        if s == 'O':
            total = total + cur
            cur = cur + 1
        else:
            cur = 1
    
    print(total)
