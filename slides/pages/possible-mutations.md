# Applying Mutations to Code

<section class="grid grid-cols-2 pt-30">
<div v-click.hide="7">
````md magic-move

```csharp {all}{lines:true}
public bool IsOldEnoughToDrink(int age)
{
    if (age >= 18)
        return true;

    return false;
}
```

```csharp {3}{lines:true}
public bool IsOldEnoughToDrink(int age)
{
    if (!(age >= 18)) 
        return true;

    return false;
}
```

```csharp {3}{lines:true}
public bool IsOldEnoughToDrink(int age)
{
    if (age > 18) 
        return true;

    return false;
}
```

```csharp {3}{lines:true}
public bool IsOldEnoughToDrink(int age)
{
    if (age < 18) 
        return true;

    return false;
}
```

```csharp {4}{lines:true}
public bool IsOldEnoughToDrink(int age)
{
    if (age >= 18) 
        return false;

    return false;
}
```

```csharp {6}{lines:true}
public bool IsOldEnoughToDrink(int age)
{
    if (age >= 18) 
        return true;

    return true;
}
```

```csharp {3,4}{lines:true}
public bool IsOldEnoughToDrink(int age)
{
    if (age >= 18)
        /* Do nothing */
    
    return false;
}
```

````
</div>
<div>

<v-switch at="0" class="text-center pt-12">
  <template #1>
    <Mutation mutation="The original code"/>
  </template>
  <template #2>
    <Mutation mutation="Negate expression mutation">
      <code>condition</code> to <code>!condition</code>
    </Mutation>
  </template>
  <template #3>
    <Mutation mutation="Equality mutation">
      <code>>=</code> to <code>></code>
    </Mutation>
  </template>
  <template #4>
    <Mutation mutation="Equality mutation">
      <code>>=</code> to <code><</code>
    </Mutation>
  </template>
  <template #5>
    <Mutation mutation="Boolean mutation">
      <code>true</code> to <code>false</code>
    </Mutation>
  </template>
  <template #6>
    <Mutation mutation="Boolean mutation">
      <code>false</code> to <code>true</code>
    </Mutation>
  </template>
  <template #7>
    <Mutation mutation="Block removal mutation">
      Remove the <code>if</code> block
    </Mutation>
  </template>
</v-switch>

</div>
</section>

<div v-click class="text-center -mt-20">
  This "simple" <code>if</code> statement results in 6 possible mutations
</div>