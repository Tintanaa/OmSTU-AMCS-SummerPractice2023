﻿#language: ru
Функция: Нахождение корней
Сценарий: Если дискриминант квадратного уравнения больше 0, то квадратное уравнение имеет два корня кратности 1
    Дано Квадратное уравнение с коэффициентами (1, 0, -1)
    Когда вычисляются корни квадратного уравнения
    Тогда квадратное уравнение имеет два корня (1, -1) кратности один 

Сценарий: Если дискриминант квадратного уравнения равен 0, то квадратное уравнение имеет один корень кратности 2
    Дано Квадратное уравнение с коэффициентами (1, -2, 1)
    Когда вычисляются корни квадратного уравнения
    Тогда квадратное уравнение имеет один корень 1 кратности два

Сценарий: Если дискриминант квадратного уравнения меньше 0, то квадратное уравнение не имеет корней
    Дано Квадратное уравнение с коэффициентами (1, 0, 1)
    Когда вычисляются корни квадратного уравнения
    Тогда множество корней квадратного уравнения пустое

Сценарий: Коэффициент a квадратного уравнения не может быть равен 0
    Дано Квадратное уравнение с коэффициентами (1e-7, 0, 1)
    Когда вычисляются корни квадратного уравнения
    Тогда выбрасывается исключение ArgumentException

Сценарий: Коэффициент a квадратного уравнение не может быть не числом 
    Дано Квадратное уравнение с коэффициентами (NaN, 0, 1)
    Когда вычисляются корни квадратного уравнения
    Тогда выбрасывается исключение ArgumentException

Сценарий: Коэффициент a квадратного уравнение не может быть положительной бесконечностью 
    Дано Квадратное уравнение с коэффициентами (Double.PositiveInfinity, 0, 1)
    Когда вычисляются корни квадратного уравнения
    Тогда выбрасывается исключение ArgumentException

Сценарий: Коэффициент a квадратного уравнение не может быть отрицательной бесконечностью 
    Дано Квадратное уравнение с коэффициентами (Double.NegativeInfinity, 0, 1)
    Когда вычисляются корни квадратного уравнения
    Тогда выбрасывается исключение ArgumentException

Сценарий: Коэффициент b квадратного уравнение не может быть не числом 
    Дано Квадратное уравнение с коэффициентами (1, NaN, 1)
    Когда вычисляются корни квадратного уравнения
    Тогда выбрасывается исключение ArgumentException

Сценарий: Коэффициент b квадратного уравнение не может быть положительной бесконечностью 
    Дано Квадратное уравнение с коэффициентами (1, Double.PositiveInfinity, 1)
    Когда вычисляются корни квадратного уравнения
    Тогда выбрасывается исключение ArgumentException

Сценарий: Коэффициент b квадратного уравнение не может быть отрицательной бесконечностью 
    Дано Квадратное уравнение с коэффициентами (1, Double.NegativeInfinity, 1)
    Когда вычисляются корни квадратного уравнения
    Тогда выбрасывается исключение ArgumentException

Сценарий: Коэффициент c квадратного уравнение не может быть не числом 
    Дано Квадратное уравнение с коэффициентами (1, 0, NaN)
    Когда вычисляются корни квадратного уравнения
    Тогда выбрасывается исключение ArgumentException

Сценарий: Коэффициент c квадратного уравнение не может быть положительной бесконечностью 
    Дано Квадратное уравнение с коэффициентами (1, 0, Double.PositiveInfinity)
    Когда вычисляются корни квадратного уравнения
    Тогда выбрасывается исключение ArgumentException

Сценарий: Коэффициент c квадратного уравнение не может быть отрицательной бесконечностью 
    Дано Квадратное уравнение с коэффициентами (1, 0, Double.NegativeInfinity)
    Когда вычисляются корни квадратного уравнения
    Тогда выбрасывается исключение ArgumentException
