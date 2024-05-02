# 1159 농구 경기

import sys
input = sys.stdin.readline

n = int(input()[:-1])
dic = {}

for _ in range(n):
    s = input()[0]
    if s in dic:
        dic[s] = dic[s] + 1
    else:
        dic[s] = 1

arr = sorted([k for k, v in dic.items() if v >= 5])
if len(arr) > 0:
    print(''.join(arr))
else:
    print("PREDAJA")