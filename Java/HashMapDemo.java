import java.util.HashMap;
import java.util.Map;

public class HashMapDemo {
    public static void main(String[] args) {

        // 1. Create a HashMap with String keys and Integer values
        HashMap<String, Integer> scores = new HashMap<>();

        // 2. Add key-value pairs using put()
        scores.put("Alice", 85);
        scores.put("Bob", 92);
        scores.put("Charlie", 78);
        scores.put("Diana", 90);

        // 3. Overwrite existing value
        scores.put("Alice", 88);  // replaces 85

        // 4. Get a value by key
        System.out.println(String.format("Score of Alice: %d", scores.get("Alice")));

        // 5. Check if a key exists
        if (scores.containsKey("Bob")) {
            System.out.println(String.format("Bob's score: %d", scores.get("Bob")));
        }

        // 6. Remove an entry
        scores.remove("Charlie");

        // 7. Iterate over entries
        System.out.println("All scores:");
        for (Map.Entry<String, Integer> entry : scores.entrySet()) {
            System.out.println(String.format("%s : %d", entry.getKey(), entry.getValue()));
        }

        // 8. Get size of the map
        System.out.println(String.format("Total entries: %d", scores.size()));

        // 9. Check if map is empty
        System.out.println(String.format("Is map empty? ", scores.isEmpty()));

        // 10. Clear the map
        scores.clear();
        System.out.println(String.format("After clearing: %s", scores));
    }
}
