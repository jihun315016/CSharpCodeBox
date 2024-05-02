# 3029 경고 

import sys
input = sys.stdin.readline

curArr = list(map(int, input().split(':')))
bombArr = list(map(int, input().split(':')))

curTime = curArr[0] * 3600 + curArr[1] * 60 + curArr[2]
bombTime = bombArr[0] * 3600 + bombArr[1] * 60 + bombArr[2]

if curTime >= bombTime:
    bombTime = bombTime + 3600 * 24

waitTime = bombTime - curTime

hour = waitTime // 3600
waitTime = waitTime % 3600

minute = waitTime // 60
second = waitTime % 60

print("%02d:%02d:%02d" % (hour, minute, second))
