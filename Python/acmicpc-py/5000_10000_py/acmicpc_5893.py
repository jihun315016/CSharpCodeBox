# 5893 17배 

s = input()
k = 0

for i in range(len(s)):
    k = k + int(s[i]) * 2 ** (len(s) - i - 1)

k = k * 17

result = ''
while k > 0:
    result = str(k % 2) + result
    k = k // 2

print(result)
