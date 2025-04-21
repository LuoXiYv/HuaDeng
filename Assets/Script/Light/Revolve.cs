using System;
using System.Collections;
using UnityEngine;

public class Revolve : MonoBehaviour
{
    private Vector3 lastPosition;
    public static int currentFace = 8;
    public static int newFace;
    private bool isOpen = false;
    public GameObject light;
    public GameObject deep;
    

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SetnewFace();
        }
        if (StatusBarCL.islight || StatuBarWS.islight || StatuBarS.islight)
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                SoundManager.ZhuanDeng();
                currentFace += 2;
                if (currentFace > 11)
                {
                    currentFace = 0;
                }
                switch (currentFace)
                {
                    case 7 or 8:
                    {
                        currentFace = 8;
                        deep.transform.rotation = Quaternion.Euler(-90, 0, -120);
                        break;
                    }
                    case 9 or 10:
                    {
                        currentFace = 10;
                        deep.transform.rotation = Quaternion.Euler(-90, 0, -60);
                        break;
                    }
                    case 11 or 0:
                    {
                        currentFace = 0;
                        deep.transform.rotation = Quaternion.Euler(-90, 0, 0);
                        break;
                    }
                    case 1 or 2:
                    {
                        currentFace = 2;
                        deep.transform.rotation = Quaternion.Euler(-90, 0, 60);
                        break;
                    }
                    case 3 or 4:
                    {
                        currentFace = 4;
                        deep.transform.rotation = Quaternion.Euler(-90, 0, 120);
                        break;
                    }
                    case 5 or 6:
                    {
                        currentFace = 6;
                        deep.transform.rotation = Quaternion.Euler(-90, 0, 180);
                        break;
                    }
                }
            }
            else if (Input.GetKeyDown(KeyCode.Z))
            {
                SoundManager.ZhuanDeng();
                currentFace -= 2;
                if (currentFace < 0)
                {
                    currentFace = 10;
                }
                switch (currentFace)
                {
                    case 7 or 8:
                    {
                        currentFace = 8;
                        deep.transform.rotation = Quaternion.Euler(-90, 0, -120);
                        break;
                    }
                    case 9 or 10:
                    {
                        currentFace = 10;
                        deep.transform.rotation = Quaternion.Euler(-90, 0, -60);
                        break;
                    }
                    case 11 or 0:
                    {
                        currentFace = 0;
                        deep.transform.rotation = Quaternion.Euler(-90, 0, 0);
                        break;
                    }
                    case 1 or 2:
                    {
                        currentFace = 2;
                        deep.transform.rotation = Quaternion.Euler(-90, 0, 60);
                        break;
                    }
                    case 3 or 4:
                    {
                        currentFace = 4;
                        deep.transform.rotation = Quaternion.Euler(-90, 0, 120);
                        break;
                    }
                    case 5 or 6:
                    {
                        currentFace = 6;
                        deep.transform.rotation = Quaternion.Euler(-90, 0, 180);
                        break;
                    }
                }
            }
            if (!Transmission.isInWS && !Transmission.isInside)
            {
                if (Input.GetKeyDown(KeyCode.Q) && isOpen && StatusBarCL.islight )
                {
                    Rot();
                    light.SetActive(false);
                    isOpen = false;
                }
                else if (!isOpen && Input.GetKeyDown(KeyCode.Q) && StatusBarCL.islight)
                {
                    light.SetActive(true);
                    isOpen = true;
                }
            }
            else if (Transmission.isInside && WindowsCT.ban && StatuBarS.islight)
            { 
                if (Input.GetKeyDown(KeyCode.Q) && isOpen )
                {
                    Rot();
                    light.SetActive(false);
                    isOpen = false;
                }
                else if (!isOpen && Input.GetKeyDown(KeyCode.Q))
                {
                    light.SetActive(true);
                    isOpen = true;
                }
            }
            else if (Transmission.isInside && !WindowsCT.ban)
            {
                if (Input.GetKeyDown(KeyCode.Q) && isOpen )
                {
                    newFace = currentFace;
                }
            }
            else if (Transmission.isInWS && Steamer.ban && StatuBarWS.islight)
            {
                if (Input.GetKeyDown(KeyCode.Q) && isOpen )
                {
                    Rot();
                    light.SetActive(false);
                    isOpen = false;
                }
                else if (!isOpen && Input.GetKeyDown(KeyCode.Q))
                {
                    light.SetActive(true);
                    isOpen = true;
                }
            }
            
        }

        if (StatusBarCL.open || StatuBarWS.open || StatuBarS.isback)
        {
            light.SetActive(false);
            isOpen = false;
        }
    }
    
     public string Rot()
     {
         newFace = currentFace;
        switch (newFace)
        {
            case 7 or 8:
            {
                newFace = 8;
                deep.transform.rotation = Quaternion.Euler(-90, 0, -120);
                break;
            }
            case 9 or 10:
            {
                newFace = 10;
                deep.transform.rotation = Quaternion.Euler(-90, 0, -60);
                break;
            }
            case 11 or 0:
            {
                newFace = 0;
                deep.transform.rotation = Quaternion.Euler(-90, 0, 0);
                break;
            }
            case 1 or 2:
            {
                newFace = 2;
                deep.transform.rotation = Quaternion.Euler(-90, 0, 60);
                break;
            }
            case 3 or 4:
            {
                newFace = 4;
                deep.transform.rotation = Quaternion.Euler(-90, 0, 120);
                break;
            }
            case 5 or 6:
            {
                newFace = 6;
                deep.transform.rotation = Quaternion.Euler(-90, 0, 180);
                break;
            }
        }

        return newFace.ToString();
    }

     public void SetLight()
     {
                 switch (newFace)
                 {
                     case 7 or 8:
                     {
                         newFace = 8;
                         deep.transform.rotation = Quaternion.Euler(-90, 0, -120);
                         break;
                     }
                     case 9 or 10:
                     {
                         newFace = 10;
                         deep.transform.rotation = Quaternion.Euler(-90, 0, -60);
                         break;
                     }
                     case 11 or 0:
                     {
                         newFace = 0;
                         deep.transform.rotation = Quaternion.Euler(-90, 0, 0);
                         break;
                     }
                     case 1 or 2:
                     {
                         newFace = 2;
                         deep.transform.rotation = Quaternion.Euler(-90, 0, 60);
                         break;
                     }
                     case 3 or 4:
                     {
                         newFace = 4;
                         deep.transform.rotation = Quaternion.Euler(-90, 0, 120);
                         break;
                     }
                     case 5 or 6:
                     {
                         newFace = 6;
                         deep.transform.rotation = Quaternion.Euler(-90, 0, 180);
                         break;
                     }
                 }
     }
    public void ReSetRotation()
    {
        newFace = 8;
        deep.transform.rotation = Quaternion.Euler(-90, 0, -120);
    }

    public void OpenLight()
    {
        light.SetActive(true);
        isOpen = true;
    }

    public void CloseLight()
    {
        light.SetActive(false);
        isOpen = false;
    }

    void SetnewFace()
    {
        Debug.Log(newFace);
    }
}
