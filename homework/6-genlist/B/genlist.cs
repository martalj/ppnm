public class genlist<T>{
        public T[] data;
        public int size = 0,capacity=8;
        public genlist(){ data = new T[capacity]; }
        public void push(T item){
		if(size==capacity){
		T[] newdata = new T[capacity*=2];
                for(int i=0;i<size;i++)newdata[i]=data[i];
                data=newdata;
		} //if
	data[size]=item;
	size++;
        } //push
	
	public void remove(int i){
		for(int j=0;j<size;j++){
			if(j==i){
				data[j]=data[j+1];
				size--;
			} //if
		} //for
	} //remove

} //class
