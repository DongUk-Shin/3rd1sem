#include <stdio.h>
#include <stdlib.h>
#define MAX_ELEMENT 200

typedef struct {
	int id;
	int avail;
} element;
typedef struct
{
	element heap[MAX_ELEMENT];
	int heap_size;
} HeapType;

HeapType* create()
{
	return (HeapType*)malloc(sizeof(HeapType));
}

void init(HeapType* h)
{ 
	h->heap_size = 0;
}

void insert_min_heap(HeapType* h, element item)
{
	int i;
	i = ++(h->heap_size);

	while ((i != 1) && (item.avail < h->heap[i / 2].avail)) 
	{
		h->heap[i] = h->heap[i / 2];
		i /= 2;
	}
	h->heap[i] = item;
}

element delete_min_heap(HeapType* h)
{
	int parent, child;
	element item, temp;

	item = h->heap[1];
	temp = h->heap[(h->heap_size)--];
	parent = 1;
	child = 2;
	while (child <= h->heap_size)
	{
		if ((child < h->heap_size) &&
			(h->heap[child].avail) > h->heap[child + 1].avail)
			child++;
		if (temp.avail < h->heap[child].avail) break;

		h->heap[parent] = h->heap[child];
		parent = child;
		child *= 2;
	}
	h->heap[parent] = temp;
	return item;
}

int main(void)
{
	element m = { 0, 0 };
	HeapType* h;
	h = create();
	init(h);

	int MACHINES = 0;

	printf("머신의 갯수를 입력하시오: ");
	scanf("%d", &MACHINES);

	int size = 0;
	printf("배열의 크기를 입력하세요: ");
    scanf("%d", &size);

	int jobs[size];

	printf("%d 개의 정수를 내림차순으로 입력하세요 (공백으로 구분하여 한 줄에 입력): ", size);
    for (int i = 0; i < size; i++) {
        scanf("%d", &jobs[i]);
    }

	for (int i = 0; i < MACHINES; i++)
	{
		m.id = i + 1;
		m.avail = 0;
		insert_min_heap(h, m);
	}
	for (int i = 0; i < size; i++) {
		m = delete_min_heap(h);
		printf("JOB %d을 시간=%d부터 시간=%d까지 기계 %d번에 할당 \n",
			i, m.avail, m.avail + jobs[i] - 1, m.id);

		printf("\n");
		m.avail += jobs[i];
		insert_min_heap(h, m);
	}
	return 0;
}

