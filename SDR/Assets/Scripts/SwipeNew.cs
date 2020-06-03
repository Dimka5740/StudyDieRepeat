﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class SwipeNew : MonoBehaviour
{
<<<<<<< Updated upstream
=======
    public Text textOfCard;
    private int health, psyhic, study, socio;
>>>>>>> Stashed changes
    //public GameObject Card;
    public Text textOfCard, gameOverText;
    public float speed;
    public int timeOfLockSwype;
    public StickerLogic sl;
    public string[,] EndGame;

    private int health, psycho, study, socio;
    private List<StoryEvent> MainList;
    private Logic bufLogic;
    private bool isSecondSwype, isMoving, gameOver;
    private DateTime end;
    private int i;
    private Vector3 positionOfImg;
    //private 
    
    private Image img, imgLittle;
    
    // Start is called before the first frame update
    private TimeSpan TimeLeft()
    {
        return end - DateTime.Now;
    }
    void Start()
    {
        SwypeController.SwypeEvent += CheckSwype2;
        MainList = new List<StoryEvent>();
        isSecondSwype = isMoving = gameOver = false;
        img = GameObject.Find("Sticker").GetComponent<Image>();
        imgLittle = GameObject.Find("StickerLittle").GetComponent<Image>();
        i = 0;
        positionOfImg = imgLittle.transform.position;
        EndGame = new string[2, 4];
        #region
        EndGame[0, 0] = "Ваше физическое состояние воодушевляет. Вы настолько хороши, что вас зовут сниматься в кино. Вы соглашаетесь и бросаете учёбу.";
        EndGame[1, 0] = "Учёба довела вас до физического истощения. Родители ссылают вас к бабуле в деревню откармливаться.";
        EndGame[0, 1] = "Вы Настолько расслаблены, что всё мирское стало вам чуждо. Вы понимаете, что ничего не имеет значения. Буддисты терерь поклоняются вам, и вы ведёте их к просветлению.";
        EndGame[1, 1] = "Вы посреди пары, без причины начинаете кидать в людей ручками, тетрадями и громко кричать. Быстроприбывшие санитары увозят вас в псих-больницу.";
        EndGame[0, 2] = "Универ даёт слишком мало материала для вашего образования. Вы решаетесь бросить университет и заняться самообразованием, но отсутствие диплома впоследствии ещё не раз аукнется вам.";
        EndGame[1, 2] = "Вы учитесь хуже всех на факультете. новые знания не усваиваются, а старые погружаются в туман времени. в скором времени вы забываете, как дышать...";
        EndGame[0, 3] = "Вы настолько много общаетесь с людьми,  что быстро находите любовь всей своей жизни. Вы и ваша вторая половинка уезжаете в глушь, чтобы посвятить себя друг другу. Заводите коз и курей. Образование вам больше не нужно. ";
        EndGame[1, 3] = "Сверстники отвернулись от вас. Преподаватели и родители не понимают вас. Вы даёте обет молчания и уходите в монастырь.";

        MainList.Add(new StoryEvent("Учебная группа", "Привет Универ! Вы поступили в самый лучший университет города! Вы находитесь на линейке, рядом много первокурсников и среди них вы находите свою группу. В центре группы вещает какой-то крутой парень. Вы подходите к ним и этот парень говорит вам: Хэй, бро, меня зовут Паша Крутыш, а тебя ?  Вы хотите пожать ему руку?", "Пожимаете руку, внутренне успокоившись, что вас хорошо приняли. Продолжаете знакомиться с другими студентами. ", 0, 10, 0, 15, "Вы отказываете парню, поскольку уверены, что сами собираетесь быть лидером в группе.", 0, -10, 0, -15, false));
        MainList.Add(new StoryEvent("Учебная группа", "Пришло время забрать свои пропуски в универ. Сегодня последний день, а вам нужно торопиться домой. Хотите его забрать сейчас?", "Быстро забрав свой пропуск вы торопитесь домой и бежите по территории универа. Внезапно вы спотыкаетесь о бордюр и падаете в лужу! Эту ситуацию видят проходящие рядом третьекурсники и смеются с вас...", -5, -20, 0, -5, "Вы решаете попробовать забрать пропуск завтра и сегодня едете домой. Придя на следующий день в интернет-центр, вы получаете пропуск но на вас жалуется диспечтер универа и вам попадает от куратора группы", 0, -10, -10, 0, false));
        MainList.Add(new StoryEvent("учебная группа", "Через неделю ваша первая контрольная точка. Вы чувствуете что очень слабы в этом предмете и похоже, что без хорошей подготовки вы ее завалите. Будете готовится?", "Вы усиленно готовитесь всю неделю и сдаете контрольную на идельный балл.", -5, 0, 15, -5, "Вы решаете отдыхать всю неделю и тусоваться с одногруппниками. Вас преследует страх не сдать, но ближе к контрольной одногруппники говорят вам, что списать у этого препода очень легко. В день контрольной вы спокойно списываете работу и получаете хороший балл!", 0, -20, 10, 10, false));
        MainList.Add(new StoryEvent("Спорт", "Вас позвали поучаствовать в осеннем легкоатлетическом кроссе за свой факультет, но на носу новая контрольная. Пойдете?", "Вы соглашаетесь и своим результатом помогаете факультету победить в общем зачете! Но контрольную из-за посещения тренировок вы заваливаете...", 10, 5, -10, 10, "Вы отказываетесь от участия и спокойно заниматесь подготовкой к контрольной.", 0, 15, 15, -5, false));
        MainList.Add(new StoryEvent("Посвят", "Всех первокурсников позвали на посвящение факультета, там можно будет неплохо потусить и с кем нибудь познакомится, но там будет очень много людей. Вы пойдете?", "Итак, вы едете на посвят на никому не известную базу за городом, вы волнуетесь за то как все пройдет, но зато отдохнете на свежем водухе.", 5, -20, 0, 5, "Вы решаете, что вам уже много отдыхать и требуется сосредоточиться на более важных вещах.", 0, -5, 10, -30, true));
        MainList.Add(new StoryEvent("Посвят", "На официальной части посвята еще трезвые организаторы проводят конкурсы на скорость реакции. Хотите поучаствовать?", "Вы и еще несколько человек встаете вокруг стола. Когда музыка заканчивается вы должны успеть выпить стакан с неопознанным напитком быстрее своего оппонента. Вы быстро заливаете все содержимое в горло и побеждаете! Публика вам оплодирует!", -10, 5, 0, 20, "Вы отказались от участия и наблюдаете за тем как люди напиваются без вас", 0, -5, 0, 0, true));
        MainList.Add(new StoryEvent("учебная группа", "твой друг просит помочь ему ответить на проверочной на один из вопросов. Поможешь?", "зная ответ, ты помогаешь ему, но не успеваешь дописать свой билет и получаешь неуд.", 0, -10, -10, 5, "друг обиделся на тебя, и вы перестали общаться на некоторое время. ", 0, -10, 10, -5, false));
        MainList.Add(new StoryEvent("учебная группа", "вы выходите из универа и видите на стене рекламный баннер. Скоро в город приезжает ваша любимая группа, но на следующий день назначена сложная практическая работа. Будете готовиться?", "вы провели за учебниками всю ночь не смыкая глаз,", -5, -20, 15, -10, "Концерт прошёл прекрасно. Полный отчаяния подъём с кровати ранним утром преобразился, когда вы узнали что преподаватель заболел и проставил всем зачёт автоматом.", 10, 20, 15, 10, false));
        MainList.Add(new StoryEvent("учебная группа", "Друг предлагает вам разыграть обморок на зачёте, так как вы не подготовились, а развлекались.", "Во время зачета вы падаете в обморок Окружающие в ужасе. Вас на скорой увозят в больницу, а преподаватель ставит всем зачёт, так как понимает что слишком загрузил группу.", 0, -10, 10, 5, "Вы и правда плохо подготовились. Преподаватель ставит вам заслуженный неуд.", 0, 0, -20, 0, false));
        MainList.Add(new StoryEvent("Субботник", "Всю вашу группу пригласили прибираться на территории университета. Однако вам совсем не хочется этим сегодня заниматься. Вы пойдете?", "Вы соглашаетесь и через лень идете прибираться вместе с одногруппниками. Работы оказывается немного, и вы быстро с ней справляетесь.", -5, 5, 0, 15, "Вы оставляете своих одногруппников прибираться без вас, чем увеличиваете им работу. Они сильно разочаровываются в вас.", 10, -5, 0, -20, false));
        MainList.Add(new StoryEvent("написание лаб для одногрупов", "Так как вы почти лучше всех в группе выполнили лабораторную работу, одногруппник просит вас решить ему ее за деньги. Согласитесь ли вы помочь ему?", "Вы беретесь за данную работу и успешно выполняете её. Однако одногруппник получает за нее балл ниже проходного и просит деньги обратно.", 0, -10, -5, -5, "Вы отказываетесь брать на себя такую ответственность, да и в добавок свободного времени у вас не так много. Одногруппник обращается к другому человеку и успешно сдает эту работу.", 0, 5, 5, 0, false));
        MainList.Add(new StoryEvent("день рождения", "Чтобы произвести хорошее впечатление на одногруппников, вам приходит в голову мысль, позвать всех после пар в столовую и угостить тортом с чаем. Будете ли вы так делать?", "Все кто хотел, пришли в столовую, покушали тортик, отлично провели время и поблагодарили вас за это.", 0, 10, 0, 15, "Отказавшись от идеи, вы как обычно пошли после пар домой.", 0, -5, 0, -5, false));
        MainList.Add(new StoryEvent("преподаватель посылает вас на олимпиаду", "Списав контрольную, и получив за нее наивысший балл, вы производите впечатление на преподавателя, и он приглашает вас принять участие в олимпиаде. Рискнете ли вы принять участие?", "Вы соглашаетесь с предложением и принимаете участие в олимпиаде. К удивлению вы легко решаете задания и набираете высокий балл. Преподаватель и одногруппники начинают уважать вас больше.", -5, 15, 15, 10, "Преподаватель очень расстраивается вашим отказом. Однако это не критично.", 0, 0, -5, 0, false));
        MainList.Add(new StoryEvent("драка ", "Вы сидите на 3 паре и мечтаете о том, чтобы сходить до буфета и купить багет. Но по приходу в буфет, парень прямо перед вами скупает последнюю штуку. Злость просто переполняет вас. Полезете ли вы с ним в драку?", "В результате вы выходите победителем, но осознав все произошедшее, вы не понимаете что на вас нашло и зачем нужна была эта драка, вам дико за нее стыдно. Все на вас смотрят с полным недоумеванием. Вы извеняетесь и предлагаете помощь.", -30, -30, 0, -30, "Сдержав свою злость, вы покупаете что-то другое из выпечки, и оно оказывается даже вкуснее. Вы очень рады что все именно так закончилось.", 0, 15, 0, 0, false));
        #endregion

        //заполнили всё говно
    }
    private void CheckSwype2(SwypeController.SwypeType type)
    {
        if (gameOver == false)
<<<<<<< Updated upstream
        {
            if (TimeLeft() < TimeSpan.Zero)
            {
                speed = 10f;
                switch (type)
                {
                    case SwypeController.SwypeType.LEFT:
                        speed = -Mathf.Abs(speed);
                        if (isSecondSwype == false)
                            SetChenges(MainList[i].NoText, MainList[i].NoHealth, MainList[i].NoPsyhic, MainList[i].NoStudy, MainList[i].NoSosiety);
                        else
                            SetText();
                        break;
                    case SwypeController.SwypeType.RIGHT:
                        speed = Mathf.Abs(speed);
                        if (isSecondSwype == false)
                            SetChenges(MainList[i].YesText, MainList[i].YesHealth, MainList[i].YesPsyhic, MainList[i].YesStudy, MainList[i].YesSosiety);
                        else
                            SetText();
                        break;
                }
            }
=======
        {
            if (TimeLeft() < TimeSpan.Zero)
            {
                speed = 10f;
                switch (type)
                {
                    case SwypeController.SwypeType.LEFT:
                        speed = -Mathf.Abs(speed);
                        if (isSecondSwype == false)
                            SetChenges(MainList[i].NoText, MainList[i].NoHealth, MainList[i].NoPsyhic, MainList[i].NoStudy, MainList[i].NoSosiety);
                        else
                            SetText();
                        break;
                    case SwypeController.SwypeType.RIGHT:
                        speed = Mathf.Abs(speed);
                        if (isSecondSwype == false)
                            SetChenges(MainList[i].YesText, MainList[i].YesHealth, MainList[i].YesPsyhic, MainList[i].YesStudy, MainList[i].YesSosiety);
                        else
                            SetText();
                        break;
                }
            }
        }
        else
        {
            if (TimeLeft() < TimeSpan.Zero)
                SceneManager.LoadScene("Menu");
>>>>>>> Stashed changes
        }
        else
        {
            if (TimeLeft() < TimeSpan.Zero)
                SceneManager.LoadScene("Menu");
        }
    }

    private void TimerOn()
    {
        end = DateTime.Now.AddSeconds(timeOfLockSwype);
    }

<<<<<<< Updated upstream
=======
    private void TimerOn()
    {
        end = DateTime.Now.AddSeconds(timeOfLockSwype);
    }

>>>>>>> Stashed changes
    private void CheckEndGame(bool [,] array)
    {
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 4; j++)
            {
<<<<<<< Updated upstream
=======
<<<<<<< Updated upstream
>>>>>>> Stashed changes
                if(array[i,j] == true)
                {
                    textOfCard.text = EndGame[i, j];
                    imgLittle.enabled = false;
                    img.enabled = false;
                    gameOver = true;
                    gameOverText.enabled = true;
                }    
<<<<<<< Updated upstream
=======
=======
                sl.InduceRight(health, psyhic, study, socio);
>>>>>>> Stashed changes
>>>>>>> Stashed changes
            }
        }
    }
    private void SetText()
    {
        textOfCard.text = MainList[i].Text;
        isSecondSwype = false;
        isMoving = true;
        TimerOn();
    }

    private void SetChenges(string text, params int[] p)
    {
        isSecondSwype = true;
        textOfCard.text = text;
        CheckEndGame(sl.InduceRight(p[0], p[1], p[2], p[3]));
        i++;
        isMoving = true;
        TimerOn();
    }
    private void StickerGetFuckOut(float speed)
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if(isMoving)
        {
            if (imgLittle.transform.position.x > 3f || imgLittle.transform.position.x < -3f)
            {
                speed = 0;
                isMoving = false;
                imgLittle.transform.position = positionOfImg;
            }
            imgLittle.transform.position += new Vector3(speed * Time.deltaTime, 0);
            
        }
        //if (Input.GetMouseButton(0) && sl.isMouseOver)
        //{
        //    Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //    img.transform.position = pos;
        //}
        //else
        //{
            
        //    img.transform.position = Vector2.MoveTowards(img.transform.position, new Vector2(0, 0), fMovingSpeed);
        //}
        ////YES side
        //if (img.transform.position.x > 1)
        //{
        //    img.color = Color.green;
        //    if (isSecondText == false && TimeLeft() < TimeSpan.Zero)
        //    {
        //        textOfCard.text = MainList[i].YesText;
        //        sl.InduceRight(MainList[i].YesHealth, MainList[i].YesPsyhic, MainList[i].YesStudy, MainList[i].YesSosiety);
        //        i++;
        //        isSecondText = true;
        //        end = DateTime.Now.AddSeconds(2);
        //    }
        //    else { isSecondText = false; }
        //}
        ////NO side
        //else if (img.transform.position.x < -1)
        //{
        //    img.color = Color.red;
        //    if (Input.GetMouseButton(0) && isSecondText == false && TimeLeft() < TimeSpan.Zero)
        //    {
        //        textOfCard.text = MainList[i].NoText;
        //        sl.InduceRight(MainList[i].NoHealth, MainList[i].NoPsyhic, MainList[i].NoStudy, MainList[i].NoSosiety);
        //        i++;
        //        isSecondText = true;
        //        end = DateTime.Now.AddSeconds(2);
        //    }
        //    else { isSecondText = false; }
        //}
        //else img.color = Color.white;
    }
}

