var FaqItem = React.createClass({
	render: function () {
		return (
		<div className="panel panel-default">
			<div className="panel-heading" role="tab" id="headingcollapse0" >
				<div className="panel-title">
					<a role="button" className="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href={'#faq' + this.props.data.Id}>
						<span className="glyphicon glyphicon-search" aria-hidden="true"></span>
						<span dangerouslySetInnerHTML={{ __html: this.props.data.Question }} />
					</a>
				</div>
			</div>
			<div id={'faq' + this.props.data.Id} className="panel-collapse collapse" role="tabpanel" aria-labelledby="headingcollapse0">
				<div className="panel-body" dangerouslySetInnerHTML={{ __html: this.props.data.Answer }} />
			</div>
		</div>
		);
	}
});

var FaqAccordionReact = React.createClass({
	render: function () {
		return (
			<div className="panel-group" id="accordion" role="tablist" aria-multiselectable="true">
				{this.props.data.Items.map(function(faq) {
					return <FaqItem key={faq.Id} data={faq}/>;
				})}
			</div>
		);
	}
});