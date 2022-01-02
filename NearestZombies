using System;
using System.Collections.Generic;

public class NearestZombies
{
    public IList<int> KillNearestZombies(IList<Position> positions)
    {
        Dictionary<int, double> distances = new Dictionary<int, double>();
        int index = 0;
        foreach (Position p in positions)
        {
            double distance = Math.Sqrt(Math.Pow(p.x, 2) + Math.Pow(p.y, 2));
            distances[index++] = distance;
        }

        List<int> result = new List<int>();


        for (int i = 0; i < 5; i++)
        {
            double shortest = double.MaxValue;
            int current = -1;
            foreach (KeyValuePair<int, double> p in distances)
            {
                if (result.Contains(p.Key) || p.Value > 10)
                    continue;
                if (shortest > p.Value)
                {
                    shortest = p.Value;
                    current = p.Key;
                }
            }

            if (current != -1)
                result.Add(current);
        }

        return result;
    }
}

public struct Position
{
    public float x;
    public float y;

    public Position(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}    
