Animal obj1 = new Animal(); // Obj1 tem acesso a classe Animal, pode ser sobrescrito. (Override)
obj1.Som();

Animal obj2 = new Cachorro(); // Obj2 tem acesso a classe Animal e Cachorro, Cachorro sobrescreve. (Override)
obj2.Som();

Animal obj3 = new Gato(); // Obj3 tem acesso a classe Animal e Gato, Gato sobrescreve. (Override)
obj3.Som();