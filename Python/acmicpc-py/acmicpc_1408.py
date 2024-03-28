# 1408 24 

curTime = list(map(int, input().split(":")))
startTime = list(map(int, input().split(":")))

cur = curTime[0] * 3600 + curTime[1] * 60 + curTime[2]
start = startTime[0] * 3600 + startTime[1] * 60 + startTime[2]

diff = start - cur
if cur > start:
    diff = diff + 24 * 3600

hour = diff // 3600
diff = diff % 3600
minute = diff // 60
second = diff % 60

print("%02d:%02d:%02d" % (hour, minute, second))
