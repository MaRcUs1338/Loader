Всем привет! Надеюсь вам понравится мой Лоадер!!!

версия Framework'а: 4.7.2
Method Inject'а: Manual Map
nuget packets: Newtonsoft.Json, siticone.Desktop.UI
ВАЖНО: Если у вас проблемы с проектом, возможно проблема в nuget пакетах, попробуйте их переустановить и перезайти в проект)
![image](https://github.com/MaRcUs1338/Loader/assets/166511746/ee0298e4-0553-46cd-91dc-f52c4e58cc6f)


Итак вот наш лоадер, но как с ним работать?
1. Для начало мы поменяем токен api keyauth, это нужно для авторизации в целом!
![image](https://github.com/MaRcUs1338/Loader/assets/166511746/f523f840-4e16-4de5-816d-9d05f7450e0e)
Тут мы видим name, ownerid, secret, version. Откуда это все взять? - Берем из https://keyauth.cc/app/?page=manage-apps


2. Авторизируемся на сайте через любой удобный вам способ, берем строчку кода и меняем ее в Form1 и Form3 после чего можем сказать все готово)


3. Работа с инжектором лоадера
![image](https://github.com/MaRcUs1338/Loader/assets/166511746/f65d0e4d-cf5b-48b9-9146-6fba51b1c12e)
Тут мы видим проверку на выбранный нами элемент по строке CS2, далее происходит процесс запуска: Process.Start("cmd.exe", "/c Injector.exe SourceEngine.dll cs2.exe");
Идет запускать cmd, в котором идет запуск injector.exe и остальными параметрами. Вот как выглядят параметры для инжектора: Injector.exe dll_path processname
тоесть название инжектора, расположение дллки, если в том же пути, то просто название вашей дллки и расширение, название процесса, пример cs2.exe/explorer.exe/discord.exe и тд(можете посмотреть в диспетчере задач)
сурс самого инжектора - https://github.com/TheCruZ/Simple-Manual-Map-Injector

4. Генерация ключа
Конечно же нам нужно будет сгенерировать ключ для приложения, плюс именно keyauth, то что есть привязка по хвид
открываем раздел Licenses - https://keyauth.cc/app/?page=licenses
жмем кнопку Create Keys
![image](https://github.com/MaRcUs1338/Loader/assets/166511746/85ba8bfa-b159-41da-b07c-497d5c59b4ec)

даее настраиваем
![image](https://github.com/MaRcUs1338/Loader/assets/166511746/7c125d5e-230e-465a-a4c7-bbb1da60a1c7)

License amount - количество ключей 
License mask - маска для ключа, в каком формате он отображается, количество символов в ключе
include lowercase letters - включать строчные буквы в ключ
include uppercase letters - включать заглавные буквы в ключ
License note - Уникальное сообщение для лицензии
License  expiry unit - эквивалент времени для вашего ключа: секунда/минута/час/день/неделя/месяц/год/пожизненно
License duration - продолжительность вашей лицензии, как это работает? Продолжительность * Эквивалент = срок истечения вашего ключа, например выбираю эквивалент дни, продолжительность ставлю 3. Значит получиться День * 3 = 3 дня

5. После создания ключа он будет в формате около: 	KEYAUTH-Jd2udJ-wWR1mn-lUckvl-OYdhGT
мы, регистрируемся в лоадере нажимая снизу слева SIGN UP, далее придумываем Логин, Пароль и вводим наш ключ. Мы оказываемся в окне авторизации вводим наш логин и пароль, далее выбираем игру и жмем Inject!
ПРИЯТНОГО ИСПОЛЬЗОВАНИЯ!
