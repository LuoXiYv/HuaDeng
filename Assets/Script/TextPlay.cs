using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextPlay : MonoBehaviour
{
    public GameObject bxs1;
    public GameObject ryw1;
    public GameObject htw1;
    public GameObject mj1;
    public GameObject gn1;
    public GameObject jyzr1;
    public GameObject me;
    public TextMeshProUGUI textpro;
    public TextMeshProUGUI textpro1;
    public GameObject cv;
    public static bool get1;
    public static bool get2;
    public static bool get3;
    public static bool get4;
    public static bool get5;
    

    private int conut = 0;
    AList bxs = new AList();
    AList ryw = new AList();
    AList htw = new AList();
    AList mj = new AList();
    AList gn = new AList();
    AList jyzr = new AList();
    private void Start()
    {
        
        bxs.dh.Add(new AClass()
        {
            content = "今儿个在书院里看到几个学子在讨论上元节的词曲，其中当以“九衢仙仗豫游归，宝烛星繁换夕晖”一句最妙。",
            name = "百晓生",
        });
        bxs.dh.Add(new AClass()
        {
            content = "哎，那北街的孙家铁匠铺今儿个可真是热闹，接了百戏表演的李三李班主亲自去取定做的杂耍道具，今年啊可有新鲜看头了！",
            name = "百晓生",
        });
        bxs.dh.Add(new AClass()
        {
            content = "街尾的文竹书肆的新东家颇有些巧思，整出了个什劳子上元灯谜会……",
            name = "百晓生",
        });
        bxs.dh.Add(new AClass()
        {
            content = "七宝擂茶好喝！七宝擂茶好喝！",
            name = "百晓生",
        });
        bxs.dh.Add(new AClass()
        {
            content = "北街那家老茶肆的咸豉汤很是不错，怎奈茶汤一便口下肚，可等位须得三炷香啊……",
            name = "百晓生",
        });
        bxs.dh.Add(new AClass()
        {
            content = "“一川烟草，满城风絮，梅子黄时雨” 好词，真是好词啊……",
            name = "百晓生",
        });
        bxs.dh.Add(new AClass()
        {
            content = "南街的荣员外啊？据说是老来得子，小公子满月抓周一把握住了一架白玉算盘。",
            name = "百晓生",
        });
        bxs.dh.Add(new AClass()
        {
            content = "卯君！卯君！……哎这孩子又跑出来找霍小官人学画了！画的那鱼倒是看着适合做一道鱼羹哈哈哈哈！",
            name = "百晓生",
        });
        
        ryw.dh.Add(new AClass()
        {
            content = "从东市新进的那批苏绣丝绸，色泽光鲜、图案别致，这笔生意倒是做得不错。那套青白瓷茶具，釉色如玉，形态各异，亦是一笔不小的进账……",
            name = "荣员外",
        });
        ryw.dh.Add(new AClass()
        {
            content = "荣员外！听起来今日生意兴隆啊？",
            name = "我",
        });
        ryw.dh.Add(new AClass()
        {
            content = "是陈家大郎啊？你父亲托我寻找的珠串正巧刚从庄子上送过来，替我为你父亲捎带回去吧。",
            name = "荣员外",
        });
        
        htw.dh.Add(new AClass()
        {
            content = "笔法，乃是绘画最基础的运笔之道……",
            name = "霍同文",
        });
        htw.dh.Add(new AClass()
        {
            content = "霍小郎君这是在观赏河中游鱼吗？",
            name = "我",
        });
        htw.dh.Add(new AClass()
        {
            content = "喔，原来是陈兄啊！",
            name = "霍同文",
        });
        htw.dh.Add(new AClass()
        {
            content = "今岁入秋之后阴雨缠绵，故而往日里不得见的河鱼都游于浅水。",
            name = "霍同文",
        });
        htw.dh.Add(new AClass()
        {
            content = "河鱼比之市集上买来的鱼总是更活泼灵动，适合入画。",
            name = "霍同文",
        });
        htw.dh.Add(new AClass()
        {
            content = "霍小郎君的墨宝我仅在文竹书肆偶然见过一次，画的是郊外亭子边的翠竹，端的是风骨俊逸啊！",
            name = "我",
        });
        htw.dh.Add(new AClass()
        {
            content = "拙劣练习之作罢了，陈兄若不嫌弃，愿以此游鱼图赠与陈兄，全当博君一笑。",
            name = "霍同文",
        });
        
        mj.dh.Add(new AClass()
        {
            content = "陈家大哥！陈家大哥！快来瞧瞧我新捏的小泥人儿！",
            name = "卯君",
        });
        mj.dh.Add(new AClass()
        {
            content = "卯君的泥人大军又有新成员了？",
            name = "我",
        });
        mj.dh.Add(new AClass()
        {
            content = "不是喔，这次是送给哥哥你的礼物小泥人儿，阿翁说快要过年了，这次过年哥哥家的麻酥糖可要多为卯君留一些！",
            name = "卯君",
        });
        mj.dh.Add(new AClass()
        {
            content = "好啊原来你个小机灵鬼是在打麻酥糖的主意呢！",
            name = "我",
        });
        
        gn.dh.Add(new AClass()
        {
            content = "陈家大郎！这儿有你的货品！",
            name = "高牛",
        }); 
        gn.dh.Add(new AClass()
        {
            content = "是高大哥啊，可是我月前在文竹书肆定的那捆宣纸到了？",
            name = "我",
        }); 
        gn.dh.Add(new AClass()
        {
            content = "是个竹筒装着的，我也不清楚是不是那什么纸，文竹书肆的东家只托我将它捎带过来给你呢。",
            name = "高牛",
        }); 
        
        jyzr.dh.Add(new AClass()
        {
            content = "这位福主请留步！",
            name = "九仪真人",
        });
        jyzr.dh.Add(new AClass()
        {
            content = "真人可是在喊我？",
            name = "我",
        });
        jyzr.dh.Add(new AClass()
        {
            content = "是极，贫道今日等候于此是为了赠予福主一物。\n（灰袍道人从身边的匣子中取出了一株看起来十分新鲜的荷花递过来）",
            name = "九仪真人",
        });
        jyzr.dh.Add(new AClass()
        {
            content = "荷花？秋日怎么会有开得正好的荷花能采呢？",
            name = "我",
        });
        jyzr.dh.Add(new AClass()
        {
            content = "秋日里头阵风肃杀，正如福主所言，理当是没有像荷花这般娇嫩的花朵可摘的。",
            name = "九仪真人",
        });
        jyzr.dh.Add(new AClass()
        {
            content = "但荷花本就是在世俗纷扰中超然外物的纯洁之花，细心养护未必会消磨在萧瑟秋风中，此事还须养花之人劳心劳力啊…… ",
            name = "九仪真人",
        });
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && Collider2D.sR)
        {
            ryw1.SetActive(true);
            StartDialogue(ryw);
            conut++;
            EndDialogue(ryw);
            if (InventoryManager.items[9].count == 0)
            {
                InventoryManager.AddItem(new InventoryItem()
                {
                    id = 9,
                    count = 1
                });
            }
            get1 = true;
        }
        else if (Input.GetKeyDown(KeyCode.Q) && Collider2D.hL)
        {
            gn1.SetActive(true);
            StartDialogue(gn);
            conut++;
            EndDialogue(gn);
            if (InventoryManager.items[10].count == 0)
            {
                InventoryManager.AddItem(new InventoryItem()
                {
                id = 10,
                count = 1
                });
            }
            InventoryManagerUI.instance.UpdateUIDisplay();
            get2 = true;
        }
        else if (Input.GetKeyDown(KeyCode.Q) && Collider2D.xH)
        {
            mj1.SetActive(true);
            StartDialogue(mj);
            conut++;
            EndDialogue(mj);
            if (InventoryManager.items[8].count == 0)
            {
                InventoryManager.AddItem(new InventoryItem()
                {
                    id = 8,
                    count = 1
                });
            }
            InventoryManagerUI.instance.UpdateUIDisplay();
            get3 = true;
        }
        else if (Input.GetKeyDown(KeyCode.Q) && Collider2D.sG)
        {
            jyzr1.SetActive(true);
            StartDialogue(jyzr);
            conut++;
            EndDialogue(jyzr);
            if (InventoryManager.items[12].count == 0)
            {
                InventoryManager.AddItem(new InventoryItem()
                {
                    id = 12,
                    count = 1
                });
            }
            InventoryManagerUI.instance.UpdateUIDisplay();
            get4 = true;
        }
        else if (Input.GetKeyDown(KeyCode.Q) && Collider2D.hS)
        {
            htw1.SetActive(true);
            StartDialogue(htw);
            conut++;
            EndDialogue(htw);
            if (InventoryManager.items[11].count == 0)
            {
                InventoryManager.AddItem(new InventoryItem()
                {
                    id = 11,
                    count = 1
                });
            }
            InventoryManagerUI.instance.UpdateUIDisplay();
            get5 = true;
        }
        else if (Input.GetKeyDown(KeyCode.Q) && Collider2D.bxs)
        {
            bxs1.SetActive(true);
            conut++;
            SDBxs(bxs);
            EDBxs(bxs);
        }

        if (!Collider2D.sR)
        {
            ryw1.SetActive(false);
        }
        else if (!Collider2D.hL)
        {
            gn1.SetActive(false);
        }
        else if (!Collider2D.xH)
        {
            mj1.SetActive(false);
        }
        else if (!Collider2D.sG)
        {
            jyzr1.SetActive(false);
        }
        else if (!Collider2D.hS)
        {
            htw1.SetActive(false);
        }
        else if (!Collider2D.bxs)
        {
            bxs1.SetActive(false);
        }
    }

    void StartDialogue(AList A)
    {
        cv.SetActive(true);
        if (conut == A.dh.Count)
        {
            textpro.text = " ";
            textpro1.text = " ";
        }
        else if(conut != A.dh.Count)
        {
            textpro.text = A.dh[conut].content;
            textpro1.text = A.dh[conut].name;
        }
        
    }

    void SDBxs(AList A)
    {
        cv.SetActive(true);
        int sj = Random.Range(0, 8);
        textpro1.text = A.dh[sj].name;
        textpro.text = A.dh[sj].content;
    }

    void EDBxs(AList A)
    {
        if (conut == 2)
        {
            cv.SetActive(false);
            conut = 0;
            bxs1.SetActive(false);
        }
    }

    void EndDialogue(AList A)
    {
        if (conut == A.dh.Count+1)
        {
            cv.SetActive(false);
            conut = 0;
            if (A == ryw)
            {
                ryw1.SetActive(false);
                GameObject.Find("UI").GetComponent<GetCargoInfo>().GetInfo(10);

            }
            else if (A == htw)
            {
                htw1.SetActive(false);
                GameObject.Find("UI").GetComponent<GetCargoInfo>().GetInfo(8);

            }
            else if (A == mj)
            {
                mj1.SetActive(false);
                GameObject.Find("UI").GetComponent<GetCargoInfo>().GetInfo(6);
            }
            else if (A == gn)
            {
                gn1.SetActive(false);
                GameObject.Find("UI").GetComponent<GetCargoInfo>().GetInfo(2);
            }
            else if (A == jyzr)
            {
                jyzr1.SetActive(false);
                GameObject.Find("UI").GetComponent<GetCargoInfo>().GetInfo(12);
            }
        }
        
    }
    class AList
    {
        public List<AClass> dh = new List<AClass>();
    }

    class AClass
    {
        public string content;
        public string name;
        public Sprite avatar;
    }

   
      
 
}
