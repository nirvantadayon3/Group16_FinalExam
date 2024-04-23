﻿/*
# Name: Dylan Shira
# email: shiradv@mail.uc.edu
# Assignment Title: Final Exam
# Due Date: 4/23
# Course: IS 3050
# Semester/Year: Spring 2024
# Brief Description: Final Project, Easy Medium Hard
# Citations: https://copilot.microsoft.com/ , https://stackoverflow.com/ , https://leetcode.com/
# Anything else that's relevant: N/A
*/

using System;
 
namespace Group16_FinalExam
{
    public class Solution2
    {
        public int IslandPerimeter(int[][] grid)
        {
            int perimeter = 0;
 
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        perimeter += 4;
 
                        if (i > 0 && grid[i - 1][j] == 1) // top neighbor
                            perimeter -= 1;
 
                        if (i < grid.Length - 1 && grid[i + 1][j] == 1) // bottom neighbor
                            perimeter -= 1;
 
                        if (j > 0 && grid[i][j - 1] == 1) // left neighbor
                            perimeter -= 1;
 
                        if (j < grid[i].Length - 1 && grid[i][j + 1] == 1) // right neighbor
                            perimeter -= 1;
                    }
                }
            }
 
            return perimeter;
        }
    }
}
 