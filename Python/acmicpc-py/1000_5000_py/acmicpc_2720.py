# 2720 세탁소 사장 동혁

t = int(input())
arr = [25, 10, 5, 1]

for _ in range(t):
    n = int(input()) 

    for a in arr:
        print(n // a, end=' ')
        n = n % a
    print()
