# 2547 사탕 선생 고창영

import sys
input = sys.stdin.readline

t = int(input())

for _ in range(t):
    _ = input()
    n = int(input())
    arr = [int(input()) for _ in range(n)]

    if sum(arr) % len(arr) == 0:
        print("YES")
    else:
        print("NO")
