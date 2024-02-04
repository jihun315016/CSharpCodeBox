# 11720 숫자의 합

n = int(input())
k = int(input())
s = 0

while k > 0:
    s = s + k % 10
    k = k // 10

print(s)
