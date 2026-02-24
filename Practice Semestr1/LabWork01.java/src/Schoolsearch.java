import java.io.*;
import java.util.*;

public class Schoolsearch {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        String input;

        while (true) {
            System.out.println("\nEnter search instruction\nS[tudent]: <lastname> B[us]\nS[tudent]: <lastname>\nT[eacher]: <lastname>\nC[lassroom]: <number>\nB[us]: <number>\nQ[uit]\n");
            input = scanner.nextLine().trim();

            if (input.equalsIgnoreCase("Q") || input.equalsIgnoreCase("Quit")) {
                break;
            }

            processInput(input);
        }

        scanner.close();
        System.out.println("Program terminated.");
    }

    private static void processInput(String input) {
        String[] parts = input.split(" ");
        if (parts.length < 2) {
            System.out.println("Invalid command. Please try again.");
            return;
        }

        String command = parts[0];
        String argument = input.substring(input.indexOf(' ') + 1).trim();

        switch (command) {
            case "S:":
            case "Student:":
                if (input.endsWith("Bus") || input.endsWith("B")) {
                    argument = input.substring(input.indexOf(' '), input.indexOf(" B")).trim();
                    StudentSearch.searchByLastNameAndBus(argument);
                } else {
                    StudentSearch.searchByLastName(argument);
                }
                break;
            case "T:":
            case "Teacher:":
                TeacherSearch.searchByLastName(argument);
                break;
            case "C:":
            case "Classroom:":
                ClassroomSearch.searchByNumber(argument);
                break;
            case "B:":
            case "Bus:":
                BusSearch.searchByNumber(argument);
                break;
            default:
                System.out.println("Invalid command. Please try again.");
                break;
        }
    }
}

class StudentSearch {

    public static void searchByLastName(String lastName) {
        search("students.txt", lastName, 0, result -> {
            System.out.println("Found student: " + result[0] + " " + result[1] + " in class: " + result[3] + ", Teacher: " + result[5]);
        });
    }

    public static void searchByLastNameAndBus(String lastName) {
		//.............
    }

    public static void search(String fileName, String value, int column, SearchResultProcessor processor) {
		//.............
    }
}


class TeacherSearch {
    public static void searchByLastName(String lastName) {
		//.............
    }
}

class ClassroomSearch {

    public static void searchByNumber(String classroomNumber) {
		//.............
    }
}

class BusSearch {
    public static void searchByNumber(String busNumber) {
		//.............
    }
}

@FunctionalInterface
interface SearchResultProcessor {
    void process(String[] result);
}

class Utils {
    public static void printDuration(long startTime) {
        long endTime = System.nanoTime();
        long duration = (endTime - startTime) / 1_000_000;
        System.out.println("Search took: " + duration + " ms");
    }
}

