﻿# Cashier.App - интерфейс для кассира. Основные возможности: выбор позиции (товара) по коду, ввод количеств товара, закрытие чека (прием наличных, расчет сдачи)
<p>Порядок разворачивания (VS 2015, MS SQL SERVER 2012)</p>
<ul>
  <li>Создать БД Cashier</li>
  <li>Изменить коннекшнстринг в NHibernate.cfg.xml</li>
</ul>

<p>
Для ввода данных используется только клавиатура:
<ul>
  <li>Для добавления позиции используется #<код позиции> Enter</li>
  <li>Для добавления количества к текущей позиции <количество> Enter</li>
  <li>Для перемещения по позициям стрелки вверх/вниз</li>
  <li>Для удаления текущей позиции Del</li>
  <li>Для создания нового документа Ctrl + N</li>
  <li>Для удаления документа Ctrl + Del</li>
</ul>
</p>
