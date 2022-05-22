# BinaryTree_Test
Дано произвольное бинарное дерево, в котором узел (Node) выглядит так:
```
  interface INode
  {
  INode Left { get; }
  INode Right { get; }
  int Value { get; }
  }
```
Дан указатель на корневой узел (Root). Пример дерева (частный случай) дан на рисунке ниже.
![BinaryTree](https://user-images.githubusercontent.com/102696246/169711975-d5d32a79-a0ed-4294-8534-90670a76f3c1.png)

Задача:
Вывести в консоль все узлы дерева по уровням, начиная с нижнего и до вершины. 

Образец выходных данных:

Level 4: 24

Level 3: 2, 6, 15

Level 2: 5, 12

Level 1: 8 
