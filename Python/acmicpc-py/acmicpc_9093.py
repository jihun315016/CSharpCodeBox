# 9093 단어 뒤집기 

import sys
input = sys.stdin.readline

t = int(input())
for _ in range(t):
    arr = input().rstrip().split()

    for a in arr:
        print(a[::-1], end=' ')

    print()