﻿# Vizuelno-programiranje-Proekt-Earth Defender

#Како се игра 

Играта Earth Defender е игра за еден играч, која има за цел да развие концентрација кај играчот.
Во горниот дел на екранот се појавуваат  блокови, кои треба да бидат разбиени со топчето кое се испукува на копчето Enter.
Топчето може да се движи во ограничена рамка прикажана на екранот, но во долниот дел се наоѓа еден пул, кој со движење на стрелките лево и десно има за цел да го фати топчето, да не падне.
Помошни команди кои се имплементирани се на копчињата:
r - играта се ресетира 
esc – играта се враќа на почетното мени
р – играта се паузира
Играта се состои од две нивоа, првото  основно, додека во второто пулот е за нијанса помал и се движи побрзо, исто така и бројот на блокови кои треба да се разбијат е поголем. 
Во левиот долен агол се прикажани преостатокот на животи, кои играчот ги има, вкупно 3 за целата игра.

#Стартување на играта 

При стартување на играта се отвора глабното мени, во кое постојат опции за избор:
New game- се започнува нова игра 
How to play- кратки инструкции за играње на играта
About us-кратка информација за авторите на играта 
Quit – излез од играта 

![alt text](https://github.com/ivamih/Vizuelno-programiranje-Proekt-/blob/master/glavno%20meni.jpg?raw=true)























Кога ќе се избере опцијата New Game, се отвара следната сцена и играчот може да започне со играта.
![alt text](https://github.com/ivamih/Vizuelno-programiranje-Proekt-/blob/master/scena.png?raw=true)

#Функционалност на играта:

Играта се состои од три сцени.
Првата сцена “MainMenu” се состои од 4 копчиња, New Game, How to play, About us и Quit. За How to play и About us  задолжени се класите Open и Open2 во кои се повикува линк до .pdf фајлови.

Втората сцена “Jane” е всушност првиот левел на играта. Играчот и неговите контроли се помогнати од класата Cube, Reload и UIManager. Cube e класа во која се одредува позицијата на пулот со секое движење (движењето е само по x оска), Reload е за ресетирање на играта, а UIМanager е за паузирање на играта и за враќање на главното мени.
Главните класи на играта сe GM и GM2, кои ги извршуваат промените добиени од играњето, како разбивање на блокови (DestroyBrick()), губење живот (LoseLife()), проверка за завршување на играта, дали сме изгубиле или победиле(CheckGameOver()) .
•	DestroyBrick() – во овој метод го со секое разбивање на блоковите се намалува нивниот број, и се зголемува “score” за еден, и со секое повикување се повикува и CheckGameOver() за да знае програмот кога да даде соодветен одговор.
•	LoseLife() – во овој метод секогаш кога топчето ќе го помине долниот праг, бројот на животи го намалуваме за еден, визуелно го уништуваме движечкиот блок, повторно го повикуваме блокот  и повикуваме CheckGameOver(), за да знае програмот дали да повика Game Over ознака и инструкции за што можеме да направиме следно.
•	CheckGameOver() – овој метод е мозокот на играта, односно во овој метод проверуваме кога да преминеме на следната сцена (наредниот левел) или кога да му дадеме до знаење на играчот дека изгубил.

Дополнително класите Highscore и Highscore2 се чува најдобриот резултат и со секоја ново уништена коцка, моменталниот резултат се зголемува за еден.
Класите Bricks и Bricks2 се за блоковите и при секој допир на блок со топчето, се повикува методот од GM DestroyBrick() и се уништува визуелно самиот блок.
Класите Death и Death2 се моментот кога топчето ке го помине подот, се повикува методот од GM LoseLife() и се намалува вредноста на животи за еден.
