# 2028 자기복제수

t = int(input())

for _ in range(t):
    s = int(input())
    sqrtInput = s * s
    if sqrtInput % 10 ** len(str(s)) == s:
        print('YES')
    else:
        print('NO')
