# 13717 포켓몬 GO

import sys
input = sys.stdin.readline

n = int(input())
total = 0
maxValue = 0
name = ''

for i in range(n):
    s = input().rstrip()
    p, m = map(int, input().split())
    cnt = 0

    while m // p > 0:
        m = m - p + 2
        cnt = cnt + 1

    if cnt > maxValue:
        maxValue = cnt
        name = s

    total = total + cnt
    
print(total)
print(name)