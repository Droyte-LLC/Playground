import java.util.LinkedList;

public class LinkedListDemo {
    public static void main(String[] args) {

        // 1. Create a LinkedList of Strings
        LinkedList<String> animals = new LinkedList<>();

        // 2. Add elements to the end
        animals.add("Dog");
        animals.add("Cat");
        animals.add("Horse");

        // 3. Add elements to the beginning and end
        animals.addFirst("Elephant");
        animals.addLast("Zebra");

        // 4. Access elements
        System.out.println("First: " + animals.getFirst()); // Elephant
        System.out.println("Last: " + animals.getLast());   // Zebra
        System.out.println("Element at index 2: " + animals.get(2));

        // 5. Remove elements
        animals.remove("Cat");         // Remove by value
        animals.removeFirst();         // Remove from beginning
        animals.removeLast();          // Remove from end

        // 6. Iterate through the list
        System.out.println("All animals:");
        for (String animal : animals) {
            System.out.println("- " + animal);
        }

        // 7. Size of the list
        System.out.println("Total animals: " + animals.size());

        // 8. Check for element
        if (animals.contains("Horse")) {
            System.out.println("Horse is still in the list.");
        }

        // 9. Clear the list
        animals.clear();
        System.out.println("List cleared. Is empty? " + animals.isEmpty());
    }
}
