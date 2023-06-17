using System;
using System.Collections.Generic;

namespace ReizTech_InternExam;

public partial class InternExamProblems {
    private int CalculateDepth(Branch branch) {
        if(branch.branches.Count == 0) return 1;

        var maxDepth = 0;
        // Because the main requirement is to calculate it recursively
        foreach(var subBranch in branch.branches) {
            var depth = CalculateDepth(subBranch);
            if(depth > maxDepth) maxDepth = depth;
        }

        return maxDepth + 1;
    }

    public void Problem2() {
        Branch root = new();

        // Pass in the provided tree structure
        root.AddChildren(2);
        root.branches[0].AddChildren(1);
        root.branches[1].AddChildren(3);
        root.branches[1].branches[0].AddChildren(1);
        root.branches[1].branches[1].AddChildren(2);
        root.branches[1].branches[1].branches[0].AddChildren(1);

        var depth = CalculateDepth(root);
        Console.WriteLine("Reiz Tech Intern Exam - Question 2");
        Console.WriteLine("==================================");
        Console.WriteLine($"The depth is {depth}.");
    }
}

internal class Branch {
    public List<Branch> branches = new();

    /// <summary>
    ///     Adds a number of children to the branch.
    /// </summary>
    /// <param name="numberOfChildren"> number of children to add</param>
    public void AddChildren(int numberOfChildren) {
        for(var i = 0; i < numberOfChildren; i++) branches.Add(new Branch());
    }
}