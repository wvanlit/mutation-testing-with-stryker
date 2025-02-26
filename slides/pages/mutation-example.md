# Manual Mutation Testing

<section class="grid grid-cols-2 pt-30">
<div>
````md magic-move

```csharp {all|3}{lines:true}
public bool IsOldEnoughToDrink(int age)
{
    if (age >= 18)
        return true;

    return false;
}
```

```csharp {3|3|3}{lines:true}
public bool IsOldEnoughToDrink(int age)
{
    if (age > 18)
        return true;
        
    return false;
}
```
````
</div>

<TestResults class="h-36">
<v-switch at="0"> 
  <template #0>  
      <UnitTest state="pass" name="age = 17 -> false" />
      <UnitTest state="pass" name="age = 19 -> true" />
  </template>
  <template #3> 
      <UnitTest state="skip" name="age = 17 -> false" />
      <UnitTest state="skip" name="age = 19 -> true" />
  </template>
  <template #4> 
      <UnitTest state="pass" name="age = 17 -> false" />
      <UnitTest state="pass" name="age = 19 -> true" />
  </template>
  <template #5> 
      <UnitTest state="pass" name="age = 17 -> false" />
      <UnitTest state="pass" name="age = 19 -> true" />
      <UnitTest state="fail" name="age = 18 -> true" />
  </template>
</v-switch>
</TestResults>

</section>

<v-switch at="0" class="text-center pt-2"> 
  <template #1>  
    Our code 100% statement coverage
  </template>
  <template #2>  
    Did we cover all possible conditions?
  </template>
  <template #3> 
    We change <code>>=</code> to <code>></code>
  </template>
  <template #4> 
      <Warning name="No failures ➞ our tests are not complete" class="w-sm mx-auto" />
  </template>
  <template #5>  
    We add an extra test to catch the mutation
  </template>
</v-switch>