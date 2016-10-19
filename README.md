# Multi Color Progress Loader
> Customizable Multi Color Progress Loader which is similar to Gmail App Progress Loader.

This solution is a binding project. 

## Usage 

```
MultiColorLoader loader = new MultiColorLoader(this.View);
BtnClickMe.TouchUpInside += (sender, e) => {
    loader.Start();
    Task.Factory.StartNew(() => {
    	Thread.Sleep(4000);
    	this.InvokeOnMainThread(() => {
    		loader.Dismiss();
    	});
    });
};
```
## Output 

![](https://github.com/guntidheerajkumar/MultiColorProgressLoader/blob/master/Example.gif?raw=true)
