using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GetCargoInfo : MonoBehaviour
{
    public GameObject gob;
    public Image img;
    public TextMeshProUGUI tx;
    public TextMeshProUGUI tx1;
    public Image img1;
    public GameObject img1_1;


    public void GetInfo(int i)
    {
        img.sprite = Resources.Load<Sprite>($"CR{i}");
        gob.SetActive(true);
        switch (i)
        {
            case 1:
                tx.text = "信笺";
                tx1.text = "吾植此竹，非为私利，惟愿世人见竹思人，常思吾之政，常思吾之德。凡至此亭者，无论达官显贵、黔首苍头，皆可采撷竹之枝叶，取其笋，伐其枝，以享自然之馈赠。(信笺已经陈旧泛黄，其中却夹了一张崭新的纸条，上书“飘零之下藏金斫”）";
                break;
            case 2:
                tx.text = "宣纸";
                tx1.text = "挑夫高牛从西街捎带过来的宣纸，是月前特意向文竹书肆订购的用于灯彩糊裱的宣纸。";
                break;
            case 3:
                tx.text = "宫灯";
                tx1.text = "陈生以荣员外赠予的珠串为主要装饰物制作的一盏方形宫灯，经过雕刻、彩绘、镶嵌、鎏金等多道工序，极具观赏性、色彩鲜艳、富丽堂皇。";
                break;
            case 4:
                tx.text = "斧头";
                tx1.text = "";
                break;
            case 5:
                tx.text = "棉线";
                tx1.text = "一捆质地柔软但能扎捆出结实灯彩骨架的棉线。";
                break;
            case 6:
                tx.text = "卯君的小泥人儿";
                tx1.text = "卯君赠送的用来“预定”麻酥糖的小泥人儿，卯君向霍同文学画，学得有所小成了却并不像他的“师傅”那样痴迷于此，反而爱好捏各式各样的泥塑小人儿，这些出自卯君的作品往往颜色艳丽神态生动，是极有趣味的小工艺品，很适合作为走马灯的配饰之一。";
                break;
            case 7:
                tx.text = "浆糊";
                tx1.text = "由天然材料制成，质地介于固体和液体之间的半透明乳白色粘合剂。在灯彩的制作工程中均匀涂抹在纸张上，既不会稀薄导致粘合不牢，也不会过于粘稠而难以操作，用于保护灯彩的结构稳定、不受潮湿环境影响。";
                break;
            case 8:
                tx.text = "游鱼图";
                tx1.text = "霍同文赠予的主题为河中游鱼的画稿，虽然只是一副用于练习的作品，但霍小郎君年少成名，单单只是描绘游鱼在浅水中游弋的画面便自有一股灵气跃然纸上，游鱼的优美姿态或许可以作为鱼灯制作的参考。";
                break;
            case 9:
                tx.text = "煮制后竹片";
                tx1.text = "遴选过的优质竹材需要经过高温煮制，除了清洁尘土和防蛀之外，经过高温煮制后的竹材往往更具韧性，便于弯折成不同形状的灯彩框架。";
                break;
            case 10:
                tx.text = "珠串";
                tx1.text = "荣员外赠予父亲老货郎的珠串工艺品，由五种不同颜色的玉石串联而成，造价并不昂贵但胜在精巧有趣，如果能加以仿制作为宫灯的配饰或许会十分合适。";
                break;
            case 11:
                tx.text = "竹片";
                tx1.text = "经过筛选的结长、皮光、有韧性的优质竹材，产自郊外绿玉君亭边的竹林，据说是由一位早年间当值的、爱民如子的县令种下。";
                break;
            case 12:
                tx.text = "荷花";
                tx1.text = "一位自称九仪真人的修道者赠送的一株新鲜荷花，并且是一株由养护它的人悉心照料，在并不适合它的秋日中盛开的荷花，这是否意味着无论人或事只要潜心琢磨、适应环境，别管这是不是它的季节，都可以像这株荷花一样绽放？无论如何，一株鲜活的荷花对于制作荷花灯来说是一个不可或缺的助力。";
                break;
            case 13:
                tx.text = "荷花灯";
                tx1.text = "陈生以九仪真人赠予的荷花为灵感制作的一盏荷花灯，为了弥补荷花只开一季的遗憾，陈生在制作过程中以宣纸晕染模仿荷花花瓣的真实颜色，压褶体现荷花的鲜活脉络。";
                break;
            case 14:
                tx.text = "蜡烛";
                tx1.text = "因为体型较小而合成一捆售卖的蜡烛，十分适合用作灯彩的光源。";
                break;
            case 15:
                tx.text = "泥塑娃娃走马灯";
                tx1.text = "陈生以卯君赠予的、充作麻酥糖的“贿赂”的小泥人为灵感来源制作的走马灯制式灯彩，走马灯通常外形为类宫灯状，在其内部装有剪纸粘轮，燃灯后热气上熏，纸轮辐转，灯屏上出现人马追逐、物换景移的影像。 ";
                break;
            case 16:
                tx.text = "阴干后的竹片";
                tx1.text = "煮制后的竹材需要在阳光无法直射且干燥通风的空间中自然风干，避免因为阳光暴晒而出现裂痕或是干燥不彻底发霉腐烂。";
                break;
            case 17:
                tx.text = "鱼灯";
                tx1.text = "陈生以画师霍同文赠送的游鱼图为参考对象制作的一串鱼灯，寓意着“年年有余”，象征丰收与吉祥。鱼灯之精妙在于重现游鱼在水中的灵动姿态、追求形似与神似，这对制作者的观察力与构形能力要求极高。";
                break;
            case 18:
                tx.text = "金币";
                tx1.text = "";
                break;
            case 19:
                tx.text = "灯骨框架";
                tx1.text = "阴干后的竹片经过开条、烤制弯曲成需要的形状后，使用棉线扎捆固定形状，安装上蜡烛便是一个完整的灯骨框架。";
                break;
            case 20:
                tx.text = "绷面后的框架";
                tx1.text = "在灯骨框架上覆盖宣纸，使用浆糊均匀涂抹在各个部位后静待其晾干，便得到一个绷面后的框架，这是灯彩制作最基础的框架结构，再往上增加不同的设计与装饰便有了不同灯彩样式的衍生。";
                break;
        }
        Invoke("Close",5f);
    }
    

    public void Close()
    {
        gob.SetActive(false);
    }

    public void Tishi(int i)
    {
        img1_1.SetActive(true);
        img1.sprite = Resources.Load<Sprite>($"T{i}");
        Invoke("Gb",2f);
    }

    public void Gb()
    {
        img1_1.SetActive(false);
    }
}
