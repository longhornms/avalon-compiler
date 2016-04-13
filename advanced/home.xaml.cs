//ADD CODE BELOW HERE
	
	void SayHi(String message) {
		MessageBox.Show(message);
	}

	void ResetClick (Element el, ClickEventArgs args){
		TextArea.Nodes.Clear();
	}

	void HandleClick (Element el, ClickEventArgs args){
		TextArea.Nodes.Add(TextBox1.Text);
		SayHi(TextBox1.Text);
	}

//ADD CODE ABOVE HERE
