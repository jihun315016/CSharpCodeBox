# 5363 요다 

n = int(input())

for _ in range(n):
    s = input().split()
    print(' '.join(s[2:]), ' '.join(s[:2]))