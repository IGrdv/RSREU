# Предметная область: Доставка пиццы
В качестве предметной области будет рассматриваться частное 
предприятие «Пиццерия». Эта пиццерия работает по формату “dark kitchen”, 
или же тёмной кухни, то есть непосредственно ресторанного зала, в котором 
можно посидеть и поесть, нет, а существует лишь множество помещений, 
которые готовят еду только на доставку, без возможности самовывоза.
Для функционирования доставки необходим следующий персонал:
1. Менеджер. Он следит за запасами продуктов, необходимых для 
приготовления пиццы, доходами и расходами предприятия, занимается 
вопросами общения с клиентами, рекламы.
2. Оператор. Он принимает заказы от клиентов, оформляет их, следит 
за загруженностью, в случае перегруженности перенаправляет заказы. Также 
оператор отправляет уведомления о статусе заказов.
3. Повар. Он приготавливает заказы, упаковывает их и передает 
курьерам.
4. Курьер. Он доставляет заказы до клиентов и принимает оплату.
Главная цель бизнеса – удовлетворение нужд клиентов, поэтому для 
поддержания репутации и выручки обслуживание клиентов выступает первой 
задачей. 

Информационная система должна вести учёт заказов, контролировать загруженность ресторанов
и процесс доставки, предоставлять клиентам информацию о статусе заказов.

## Описание бизнес-процесса
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
Курьер доставляет заказ клиенту, отправляя ему сообщение “Заказ доставлен”. 
После этого он получает оплату от клиента, и отдаёт заказ ему. Заказ считается выполненным.

## Проблематика
Автоматизация данной предметной области значительно облегчит управление предприятием.
Информационная система должна вести учёт заказов, контролировать загруженность ресторанов
и процесс доставки, предоставлять клиентам информацию о статусе заказов.
Планируется создать сайт, который позволит клиентам осуществлять заказы, а также контролировать статус заказа.
Система автоматизации также будет предоставлять поварам рецепты в виде TO-DO списка. Для менеджеров будет создана база данных,
в которой будет вестись запись всех заказов, список сотрудников, клиентов, адреса клиентов.
