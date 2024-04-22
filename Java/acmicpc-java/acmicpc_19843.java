// 19843 수면 패턴

import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        Map<String, Integer> map = new HashMap<>();
        map.put("Mon", 1);
        map.put("Tue", 2);
        map.put("Wed", 3);
        map.put("Thu", 4);
        map.put("Fri", 5);

        int t = sc.nextInt();
        int n = sc.nextInt();
        sc.nextLine();

        int total = 0, time = 0;
        for (int i = 0; i < n; i++) {
            String[] arr = sc.nextLine().split(" ");            
            time = Integer.valueOf(arr[3]) - Integer.valueOf(arr[1]);

            if (!arr[0].equals(arr[2])) {
                time = time + 24 + (map.get(arr[2]) - map.get(arr[0]) - 1) * 24;
            }

            total = total + time;
        }

        if (total >= t) {
            System.out.println(0);
        }
        else if (t - total > 48) {
            System.out.println(-1);
        }
        else {
            System.out.println(t - total);
        }
    }
}
