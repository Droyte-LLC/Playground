import java.util.ArrayList;

public class ArrayListDemo {
    public static void main(String[] args) {

        // 1. Create an ArrayList of Strings
        ArrayList<String> fruits = new ArrayList<>();

        // 2. Add elements
        fruits.add("Apple");
        fruits.add("Banana");
        fruits.add("Mango");
        fruits.add("Orange");

        // 3. Access elements by index
        System.out.println(String.format("First fruit: %s", fruits.get(0))); // Apple

        // 4. Iterate through the list
        System.out.println("All fruits:");
        for (String fruit : fruits) {
            System.out.println(String.format("- %s", fruit));
        }

        // 5. Check if list contains an element
        if (fruits.contains("Mango")) {
            System.out.println("Yes, Mango is in the list.");
        }

        // 6. Remove an element
        fruits.remove("Banana");
        System.out.println(String.format("After removing Banana: %s", fruits));

        // 7. Update an element
        fruits.set(1, "Pineapple");  // Replaces Mango with Pineapple
        System.out.println(String.format("After updating: %s", fruits));

        // 8. Size of the ArrayList
        System.out.println(String.format("Total fruits: %s", fruits.size()));

        // 9. Clear the list
        fruits.clear();
        System.out.println(String.format("List cleared. Is empty? %s", fruits.isEmpty()));
    }
}
