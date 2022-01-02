using System;
using System.Collections.Generic;

public class Weapons
{
    private List<int> weapons = new List<int>();
    private int equiped = -1;
    private List<string> result = new List<string>();

    public IList<string> GameLoop(IList<string> commands)
    {
        List<string> sounds = new List<string>()
            {
                "RATATA",
                "BING",
                "BANG",
                "KABOOM",
                "BOOM",
                "ZAP",
                "WOSHH"
            };

        foreach (string str in commands)
        {
            switch (str[0])
            {
                case 'A':
                    if (weapons.Count == 2)
                        weapons.RemoveAt(0);
                    weapons.Add(int.Parse(str[1] + ""));
                    break;

                case 'E':
                    if (str[1] == '0')
                    {
                        if (weapons.Count > 0)
                            equiped = weapons[0];
                    }
                    else if (str[1] == '1')
                    {
                        if (weapons.Count > 1)
                            equiped = weapons[1];
                    }
                    break;

                case 'F':
                    result.Add(sounds[equiped]);
                    break;
            }
        }

        return result;
    }
}
