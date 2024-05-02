# 2145 숫자 놀이 

while True:
    n = int(input())
    if n == 0:
        break
    
    while True:
        s = 0
        while n > 0:
            s = s + n % 10
            n = n // 10
        
        if s < 10:
            print(s)
            break
        
        n = s