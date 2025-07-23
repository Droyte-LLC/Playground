import java.util.HashSet;

public class HashSetDemo {
    public static void main(String[] args) {

        // 1. Create a HashSet of Strings
        HashSet<String> countries = new HashSet<>();

        // 2. Add elements
        countries.add("USA");
        countries.add("Canada");
        countries.add("Mexico");
        countries.add("Brazil");

        // 3. Add duplicate (will be ignored)
        countries.add("USA");

        // 4. Print all elements (unordered)
        System.out.println("Countries in the set:");
        for (String country : countries) {
            System.out.println(String.format("- %s", country));
        }

        // 5. Check if an element exists
        if (countries.contains("Canada")) {
            System.out.println("Canada is in the set.");
        }

        // 6. Remove an element
        countries.remove("Mexico");
        System.out.println(String.format("After removing Mexico: %s", countries));

        // 7. Size of the HashSet
        System.out.println(String.format("Set size: %d", countries.size()));

        // 8. Add a null value
        countries.add(null);
        System.out.println(String.format("After adding null: %s", countries));

        // 9. Clear the set
        countries.clear();
        System.out.println(String.format("Set cleared. Is empty? %s", countries.isEmpty()));
    }
}
