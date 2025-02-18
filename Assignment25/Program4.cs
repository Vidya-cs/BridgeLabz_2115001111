using System;
using System.Collections.Generic;

interface IMealPlan{
    void DisplayMeal();
}

class VegetarianMeal : IMealPlan{
    public string Name { get; set; }
    public int Calories { get; set; }
    public VegetarianMeal(string name, int calories){
        Name = name;
        Calories = calories;
    }
    public void DisplayMeal(){
        Console.WriteLine($"[Vegetarian Meal] Name: {Name}, Calories: {Calories}");
    }
}

class VeganMeal : IMealPlan{
    public string Name { get; set; }
    public int Calories { get; set; }

    public VeganMeal(string name, int calories){
        Name = name;
        Calories = calories;
    }

    public void DisplayMeal(){
        Console.WriteLine($"[Vegan Meal] Name: {Name}, Calories: {Calories}");
    }
}

class HighProteinMeal : IMealPlan{
    public string Name { get; set; }
    public int Calories { get; set; }
    public HighProteinMeal(string name, int calories){
        Name = name;
        Calories = calories;
    }

    public void DisplayMeal(){
        Console.WriteLine($"[High Protein Meal] Name: {Name}, Calories: {Calories}");
    }
}

class Meal<T> where T : IMealPlan{
    private List<T> meals = new List<T>();
    public void AddMeal(T meal){
        meals.Add(meal);
    }

    public void DisplayMeals(){
        Console.WriteLine("Meal Plan:");
        foreach (var meal in meals){
            meal.DisplayMeal();
        }
    }
}

class Program4{
    public static void Main(string[] args){
        
        Meal<VegetarianMeal> vegetarianPlan = new Meal<VegetarianMeal>();
        Meal<VeganMeal> veganPlan = new Meal<VeganMeal>();
        Meal<HighProteinMeal> proteinPlan = new Meal<HighProteinMeal>();

        vegetarianPlan.AddMeal(new VegetarianMeal("Paneer Curry", 500));
        vegetarianPlan.AddMeal(new VegetarianMeal("Vegetable Salad", 200));

        veganPlan.AddMeal(new VeganMeal("Tofu Stir-Fry", 400));
        veganPlan.AddMeal(new VeganMeal("Vegan Smoothie", 350));

        proteinPlan.AddMeal(new HighProteinMeal("Grilled Chicken", 700));
        proteinPlan.AddMeal(new HighProteinMeal("Protein Shake", 300));

        vegetarianPlan.DisplayMeals();
        veganPlan.DisplayMeals();
        proteinPlan.DisplayMeals();
    }
}
