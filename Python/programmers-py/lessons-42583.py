# 스택/큐 > 다리를 지나는 트럭

from collections import deque

def solution(bridge_length, weight, truck_weights):
    time = 1
    truck_weights.reverse()
    current = deque()
    current.append(truck_weights.pop())
    total = sum(current)

    # total 대신 sum(current)를 사용했는데, 집계 처리 시간때문인지 시간 초과 발생
    while truck_weights:
        if len(current) + 1 > bridge_length:
            total = total - current.popleft()

        if weight - total >= truck_weights[-1]:
            # 트럭이 다리에 올라갈 수 있는 경우
            truck = truck_weights.pop()
            current.append(truck)
            total = total + truck
        else:
            # 트럭이 다리에 올라갈 수 없는 경우
            current.append(0)
        time = time + 1
    return time + bridge_length


bridge_length = 2
weight = 10
truck_weights = [7,4,5,6]
print(solution(bridge_length, weight, truck_weights)) # 8

bridge_length = 100
weight = 100
truck_weights = [10]
print(solution(bridge_length, weight, truck_weights)) # 101

bridge_length = 100
weight = 100
truck_weights = [10,10,10,10,10,10,10,10,10,10]	
print(solution(bridge_length, weight, truck_weights)) # 110

bridge_length = 666
weight = 444
truck_weights = [121, 331, 353, 154, 1, 422, 7, 8, 10, 120]
print(solution(bridge_length, weight, truck_weights)) # 3998

