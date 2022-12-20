# Square Calculator

## Task
> Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
>- Юнит-тесты
>- Легкость добавления других фигур
>- Вычисление площади фигуры без знания типа фигуры в compile-time
>- Проверку на то, является ли треугольник прямоугольным

### Project is the class library.
To create figure use the fabric method:
> IFigure CreateFigure(double radius)

It will return figure implementation based on sides.
Up to date only two implementations supported:
- Circle. can be created by providing one double argument or with list that contains only one double.
- Triangle. Can be created by providing list of 3 doubles that represents sides. 

Fabric method will create figure only if it valid. IsValid method in IFigure used for that purpose. 

Class "Triangle"  also support property "IsRight"  that indicate that is the right angled triangle or not.
For use this one requires transformation IFigure to Triangle

## Task 2 

>В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

SELECT products.name, category.name
FROM products
INNER JOIN products_to_category ON products.id = products_to_category.products_id
LEFT JOIN products ON products_to_category.category_id = category.id
