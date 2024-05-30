using System;
using System.Collections.Generic;

public class Module
{
    public static List<int> TraversedModuleIds { get; set; } = new List<int>();
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Module> Submodules { get; set; }

    public Module(int id, string name)
    {
        Id = id;
        Name = name;
        Submodules = new List<Module>();
    }

    public void AddSubmodule(Module submodule)
    {
        Submodules.Add(submodule);
    }

    public static void DisplayModuleHierarchy(List<Module> modules, int depth)
    {
        
        foreach (var module in modules)
        {
            Console.WriteLine($"{new string(' ', depth * 2)}{module.Name}");
            Module.TraversedModuleIds.Add(module.Id);   
            DisplayModuleHierarchy(module.Submodules, depth + 1);
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {

        // Create module hierarchy
        Module module1 = new Module(1, "Module 1");
        Module submodule1_1 = new Module(2, "Submodule 1.1");
        Module submodule1_1_1 = new Module(44, "Submodule 1.1.1");
        Module submodule1_1_2 = new Module(45, "Submodule 1.1.2");
        Module submodule1_1_3 = new Module(66, "Submodule 1.1.3");
        Module submodule1_1_4 = new Module(55, "Submodule 1.1.4");
        Module submodule1_1_5 = new Module(56, "Submodule 1.1.5");

        Module submodule1_2 = new Module(3, "Submodule 1.2");

        submodule1_1.AddSubmodule(submodule1_1_1); 
        submodule1_1.AddSubmodule(submodule1_1_2); 
        submodule1_1.AddSubmodule(submodule1_1_3); 
        submodule1_1.AddSubmodule(submodule1_1_4); 
        submodule1_1.AddSubmodule(submodule1_1_5); 
        
        module1.AddSubmodule(submodule1_1);
        module1.AddSubmodule(submodule1_2);

        Module module2 = new Module(4, "Module 2");
        Module submodule2_1 = new Module(58, "Submodule 2.1");
        Module submodule2_2 = new Module(68, "Submodule 2.2");

        Module submodule2_2_1 = new Module(61, "Submodule 2.2.1");
        Module submodule2_2_2 = new Module(62, "Submodule 2.2.2");
        Module submodule2_2_3 = new Module(63, "Submodule 2.2.3");
        Module submodule2_2_4 = new Module(64, "Submodule 2.2.4");
        Module submodule2_2_5 = new Module(65, "Submodule 2.2.5");

        submodule2_2.AddSubmodule(submodule2_2_1);
        submodule2_2.AddSubmodule(submodule2_2_2);
        submodule2_2.AddSubmodule(submodule2_2_3);
        submodule2_2.AddSubmodule(submodule2_2_4);
        submodule2_2.AddSubmodule(submodule2_2_5);
        
        module2.AddSubmodule(submodule2_1);
        module2.AddSubmodule(submodule2_2);

        // Assigned module IDs
        List<int> assignedModules = new List<int> { 2, 3, 4 };

        // Display hierarchy for assigned modules
        Console.WriteLine("Assigned Module Hierarchy:");
        foreach (var moduleId in assignedModules)
        {
            Module module = FindModule(module1, moduleId);
            if (module != null)
            {
                Module.DisplayModuleHierarchy(new List<Module> { module }, 0);
            }
            else
            {
                Console.WriteLine($"Module with ID {moduleId} not found.");
            }
        }

        Console.WriteLine($"Data--------> {Module.TraversedModuleIds.Count}");
        assignedModules.AddRange(Module.TraversedModuleIds);
        Console.WriteLine($"AssignedModuleIds--------> {assignedModules}");
        Console.ReadLine();
    }

    public static Module FindModule(Module root, int moduleId)
    {
        if (root.Id == moduleId)
        {
            return root;
        }

        foreach (var submodule in root.Submodules)
        {
            Module foundModule = FindModule(submodule, moduleId);
            if (foundModule != null)
            {
                return foundModule;
            }
        }

        return null;
    }
}
