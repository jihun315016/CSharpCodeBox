// 20540 연길이의 이상형

import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        Map<String, String> map = new HashMap();
        map.put("E", "I");
        map.put("I", "E");

        map.put("S", "N");
        map.put("N", "S");

        map.put("T", "F");
        map.put("F", "T");

        map.put("P", "J");
        map.put("J", "P");

        String str = sc.nextLine();
        for (char c : str.toCharArray()) {
            System.out.print(map.get(String.valueOf(c)));
        }
    }
}
