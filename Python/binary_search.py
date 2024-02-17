def get_item_in_list(
    list_of_items: list,
    item: int
) -> int:
    min = 0
    max = len(list_of_items) - 1
    count_of_iterations = 0

    while min <= max:
        middle = (min + max) // 2
        possible_value = list_of_items[middle]
        count_of_iterations += 1

        if possible_value == item:
            print(f"Count of iterations: {count_of_iterations}")
            return middle
        
        if item > possible_value:
            min = middle + 1
        else:
            max = middle - 1
    print(f"Count of iterations: {count_of_iterations}")
    return None


list_items = list(range(1,101))
item = 100

print(get_item_in_list(list_items, item))
