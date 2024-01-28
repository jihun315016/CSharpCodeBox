# 3003 킹, 퀸, 룩, 비숍, 나이트, 폰

sArr = [1, 1, 2, 2, 2, 8]
iArr = list(map(int, input().split()))

for i in range(len(iArr)):
    print(sArr[i] - iArr[i], end=' ')
