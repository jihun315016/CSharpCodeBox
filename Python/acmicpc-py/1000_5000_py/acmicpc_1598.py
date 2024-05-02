# 1598 꼬리를 무는 숫자 나열

a, b = map(int, input().split())

# 행 : 4로 나눈 나머지 - 1인데 나머지가 0이면 가장 아래 칸
# 열 : 4로 나눈 몫인데 0이면 몫에서 1 뺀 값

if a % 4 == 0:
    pointA = (3, a // 4 - 1)
else:
    pointA = (a % 4 - 1, a // 4)

if b % 4 == 0:
    pointB = (3, b // 4 - 1)
else:
    pointB = (b % 4 - 1, b // 4)

distance = abs(pointB[0] - pointA[0]) + abs(pointB[1] - pointA[1])

# 직각 거리니까 피타고라스 아님
print(distance)

