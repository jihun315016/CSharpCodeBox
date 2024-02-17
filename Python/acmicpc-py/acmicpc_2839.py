# 2839 설탕 배달

def getCount(n):
    for i in range(0, n // 3 + 1):
        for j in range(0, n // 5 + 1):
            if i * 3 + j * 5 == n:
                return i + j
            
    return -1

n = int(input())
print(getCount(n))
