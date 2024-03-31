# 1032 명령 프롬프트

import sys
input = sys.stdin.readline

n = int(input())
arr = [input() for _ in range(n)]

for i in range(len(arr[0])):
    s = arr[0][i]
    for j in range(len(arr)):
        if s != arr[j][i]:
            s = '?'
            break
    print(s, end='')

