# 연습 문제 > 공원 산책

def solution(park, routes):
    answer = []

    curX = 0
    curY = 0

    # 시작 지점 찾기
    curY, curX = getStartPoint(park)

    for r in routes:
        # 방향, 거리
        direction, distance = r.split()
        curX, curY = move(park, curX, curY, direction, int(distance))

    return [curY, curX]


def getStartPoint(park):
    for i in range(len(park)):
        for j in range(len(park[0])):
            if park[i][j] == "S":
                return i, j

def move(park, curX, curY, direction, distance):
    orgX = curX
    orgY = curY

    if direction == 'E':
        for i in range(distance):
            if curX + 1 < len(park[0]) and park[curY][curX + 1] != "X":
                curX = curX + 1
            else:
                return orgX, orgY

    elif direction == 'W':
        for i in range(distance):
            if curX - 1 >= 0 and park[curY][curX - 1] != "X":
                curX = curX - 1
            else:
                return orgX, orgY

    elif direction == "S":
        for i in range(distance):
            if curY + 1 < len(park[0]) and park[curY + 1][curX] != "X":
                curY = curY + 1
            else:
                return orgX, orgY

    else:
        for i in range(distance):
            if curY - 1 >= 0 and park[curY - 1][curX] != "X":
                curY = curY - 1
            else:
                return orgX, orgY

    return curX, curY


park = ["SOO","OOO","OOO"]
routes = ["E 2","S 2","W 1"]
print(solution(park, routes))

park = ["SOO","OXX","OOO"]
routes = ["E 2","S 2","W 1"]
print(solution(park, routes))

park = ["OSO","OOO","OXO","OOO"]
routes = ["E 2","S 3","W 1"]
print(solution(park, routes))
