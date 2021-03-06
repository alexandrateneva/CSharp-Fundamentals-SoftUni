﻿namespace BashSoft
{
    public static class ExceptionMessages
    {
        public const string DataAlreadyInitilizedException = "Data is already initialized!";
        public const string DataNotInitializedExceptionMessage = "The data structure must be initialised first in order to make any operations with it.";
        public const string InexistingStudentInDataBase = "The user name for the student you are trying to get does not exist!";
        public const string UnauthorizedAccessExceptionMessage = "The folder/file you are trying to get access needs a higher level of rights than you currently have.";
        public const string ComparisonOfFilesWithDifferentSizes = "Comparison of files with different sizes.";
        public const string UnableToGoHigherInPartitionHierarchy = "Unable to go hiher in partition hierarchy";
        public const string UnableToParseNumber = "The sequence you've written is not a valid number.";
        public const string InvalidStudentFilter = "The given filter is not one of the following: excellent/average/poor.";
        public const string InvalidComparisonQuery = "The comparison query you want, does not exist in the context of the current program!";
        public const string InvalidTakeCommand = "The take command expected doest not match the format wanted!";
        public const string InvalidTakeQuantityParameter = "The take quantity parameter doest not match the format wanted!";
        public const string StudentNotEnrolledInCourse = "Student must be enrolled in a course before you set his mark.";
        public const string InvalidNumberOfScores = "The number of scores for the given course is greater than the possible.";
        public const string InvalidScore = "The number for the score you've entered is not in the range of 0 - 100";
    }
}
