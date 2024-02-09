# 1871 좋은 자동차 번호판

n = int(input())

for _ in range(n):
    a, b = input().split('-')

    a = a.upper()
    b = int(b)

    c = 0
    for i in range(len(a)):
        c = c + (ord(a[i]) - ord('A')) * 26 ** (len(a) - i - 1)

    if abs(c - b) <= 100:
        print("nice")
    else:
        print("not nice")

