## Содержание

[Введение](#введение)

[1 Описание предметной области](#предметная_область)

[1.1 Проблематика](#проблематика)

[1.2 Описание бизнес-процесса](#бизнес)

[1.3 ER-диаграмма](#ER)

[2 Сравнительный анализ](#сравнение)



## Введение <a name="введение"></a>
Темой проекта является информационная система для пиццерии. Эта пиццерия работает по формату “dark kitchen”, 
или же тёмной кухни, то есть непосредственно ресторанного зала, в котором 
можно посидеть и поесть, нет, а существует лишь множество помещений, 
которые готовят еду только на доставку, без возможности самовывоза.

## 1 Описание предметной области <a name="предметная_область"></a>

Для функционирования доставки необходимы следующие лица:
1. Клиент. Он делает заказы, оплачивает и принимает их.
2. Оператор. Он принимает заказы от клиентов и оформляет их.
3. Повар. Он приготавливает заказы, упаковывает их и передает 
курьерам.
4. Курьер. Он доставляет заказы до клиентов и принимает наличную оплату.

Главная цель бизнеса – удовлетворение нужд клиентов, поэтому для 
поддержания репутации и выручки качество обслуживания клиентов играет значительную роль.

Отношения между действующими лицами и вариантами использования показаны на Use-Case диаграмме (рисунок 1).
![Use-case](https://user-images.githubusercontent.com/35939102/201239643-7d8fb05f-b7e6-4a47-ba2e-eb02400ff357.png)
<p align="center">Рисунок 1 - Диаграмма вариантов использования</p>

## 1.1 Проблематика <a name="проблематика"></a>

Автоматизация данной предметной области значительно облегчит управление предприятием и качество обслуживания клиентов.
Информационная система должна вести учёт заказов, контролировать загруженность ресторанов
и процесс доставки, предоставлять клиентам информацию о статусе заказов.
Планируется создать сайт, который позволит клиентам осуществлять заказы, а также контролировать статус заказа.
Система автоматизации также будет предоставлять поварам рецепты в виде TO-DO списка.
Для менеджеров будет создана база данных, хранящая данные о всех сотрудниках, клиентах, их адресах и заказах.


## 1.2 Описание бизнес-процесса <a name="бизнес"></a>

1. Клиент. Клиент выбирает пиццу и заказывает её. Далее он ожидает 
получение сообщения. Если приходит сообщение “Заказ задерживается”, то 
клиент продолжает ждать следующего сообщения. Если сообщение – “Заказ 
отменен”, то заказ отменяется. При 
получении сообщения “Заказ доставлен” он оплачивает заказ, передавая 
деньги курьеру, и получает его от него.
2. Оператор. От клиента заказ передается оператору, который 
принимает его и оформляет детали. Если выбранный клиентом или системой 
ресторан перегружен, то заказ перенаправляется в другой ресторан сети. Далее 
идёт проверка нового выбранного ресторана на перегруженность. Если же 
выбранный ресторан не перегружен, то он выбирается текущим, и в нём 
начинается приготовления заказа. Если повар готовит заказ более 60 минут, то 
оператор отправляет сообщение клиенту с извинениями. Если поступает 
сообщение от повара, что приготовить заказ невозможно, то клиента 
информируют об отмене заказа, и заказ отменяется.
3. Повар. Повар приготавливает заказ. Если заказ готовится более 60 
минут, то данная информация передаётся оператору, при этом заказ 
продолжают готовить. Если заказ по каким-то причинам не получается 
приготовить, то приготовление отменяется, оператора уведомляют 
об этом. 
4. Курьер. Если заказ удаётся приготовить, то он передается курьеру. 
Курьер доставляет заказ клиенту, после этого система отправляет сообщение “Заказ доставлен”. 
После этого он получает оплату от клиента, и отдаёт заказ ему. Заказ считается выполненным.

Бизнес-процесс представлен на BPMN-диаграмме (рисунок 2)
![BPMN](https://user-images.githubusercontent.com/35939102/195993485-6b0c709b-9c82-4dd4-9012-fd6496491eda.png)
<p align="center">Рисунок 2 - Диаграмма бизнес-процесса</p>

## 1.3 ER-диаграмма <a name="ER"></a>
Связи между сущностями (людьми, объектами, событиями и т.д) показаны на диаграмме "сущность-связь" (рисунок 3).
![IDEF1X](https://user-images.githubusercontent.com/35939102/201239814-28ceb115-3633-438b-9996-13524923e65c.png)
<p align="center">Рисунок 3 - Диаграмма Entity Relationship </p>

## 2 Сравнительный анализ <a name="сравнение"></a>

Одной из самых популярных систем автоматизации для бизнеса является r_keeper. R_keeper является первой системой 
в России для автоматизации бизнеса данного рода. Она имеет большое количество модулей, легко внедряется и 
эксплуатируется, а также часто обновляется.

Данная система имеет множество недостатков. Во-первых, из-за большого количества клиентов техподдержка является некачественной и медленной.
Клиентам иногда приходится ждать ответа неделями. Система имеет высокую цену, за дополнительные функции приходится доплачивать.
Из-за этого на рынке процветает торговля "взломанным р_кипером", что усложняет техническую поддержку и создаёт множество проблем.
Другой популярной ИС является iiko, однако она имеет схожие недостатки: медленная техподдержка, высокая цена, устаревший функционал.

Разрабатываемая информационная система будет иметь открытый исходных код, что устраняет множество проблем. Оплата будет взиматься только за
внедрение и поддержку, так что цена всегда будет оставаться низкой. Все уязвимости будут оперативно исправляться, а техподдержку также смогут 
проводить сторонние лица.



