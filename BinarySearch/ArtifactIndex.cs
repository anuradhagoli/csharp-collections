using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.BinarySearch
{
    internal class ArtifactIndex
    {
        static int FindArtifactIndex(int[] values, int start, int end, int artifactValue)
        {
            if (start > end) return -1; // Base case: Artifact not found
            int mid = start + (end - start) / 2; // Find the midpoint
            if (values[mid] == artifactValue) return mid; // Artifact found
            if (values[mid] > artifactValue)
                return FindArtifactIndex(values, start, mid - 1, artifactValue); // Check the left half
            return FindArtifactIndex(values, mid + 1, end, artifactValue); // Check the right half
        }
        public void Run()
        {
            int[] artifactValues = { 3, 7, 12, 19, 23, 31 }; // Sorted array of artifact values
            int artifactToFind = 23; // Value of the artifact to find
            Console.WriteLine(FindArtifactIndex(artifactValues, 0, artifactValues.Length - 1, artifactToFind)); // Outputs: 0
        }   
    }
}
