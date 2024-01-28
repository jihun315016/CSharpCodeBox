# 2475 검증수 

arr = list(map(int, input().split()))
s = 0

for a in arr:
    s = s + a**2

print(str(s)[-1])
